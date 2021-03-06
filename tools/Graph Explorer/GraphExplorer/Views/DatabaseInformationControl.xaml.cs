﻿using SocratexGraphExplorer.Models;
using SocratexGraphExplorer.ViewModels;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace SocratexGraphExplorer.Views
{
    /// <summary>
    /// Interaction logic for DatabaseInformationControl.xaml
    /// </summary>
    public partial class DatabaseInformationControl : UserControl
    {
        private EditorViewModel ViewModel { get; set; }
        private Model Model { get; set; }

        public DatabaseInformationControl(EditorViewModel viewModel, Model model)
        {
            this.ViewModel = viewModel;
            this.Model = model;

            InitializeComponent();

            this.DataContext = this;
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var metadataQuery = @"
CALL db.labels() YIELD label
RETURN {name:'labels', data:COLLECT(label)[..1000]} AS result
UNION ALL
CALL db.relationshipTypes() YIELD relationshipType
RETURN {name:'relationshipTypes', data:COLLECT(relationshipType)[..1000]} AS result
UNION ALL
MATCH () RETURN { name:'nodes', data:count(*) } AS result
UNION ALL
MATCH ()-[]->() RETURN { name:'relationships', data: count(*)} AS result";

            var result = await Model.ExecuteCypherAsync(metadataQuery);
            var labels = ((result[0].Values["result"] as Dictionary<string, object>)["data"] as List<object>);
            var labelsCount = (long)(result[2].Values["result"] as IDictionary<string, object>)["data"];

            this.LabelsPrompt.Text = string.Format("Node Labels ({0})", labelsCount);

            foreach (var label in labels)
            {
                var labelGlyph = new MaterialDesignThemes.Wpf.Chip()
                {
                    Margin = new Thickness(5,0,5,5),
                    Content = label as string,
                    IsDeletable = false,
                    ToolTip = "Calculating...",
                };

                labelGlyph.Click += (_, e) => { LabelClicked(label as string); };

                labelGlyph.ToolTipOpening += LabelTooltipOpening;
                this.Nodes.Children.Add(labelGlyph);
            }

            var relationships = ((result[1].Values["result"] as Dictionary<string, object>)["data"] as List<object>);
            var relationshipCount = (long)(result[3].Values["result"] as IDictionary<string, object>)["data"];

            this.RelationshipsPrompt.Text = string.Format("Relationships ({0})", relationshipCount);

            foreach (var relationship in relationships)
            {
                var edgeGlyph = new Button()
                {
                    Style = this.Resources["Edges"] as Style,
                    Margin = new Thickness(-4,-0,-4, 0),
                    Content = "-[" + (relationship as string) + "]-",
                    ToolTip = "Calculating...",
                };

                edgeGlyph.Click += (_, e) => { EdgeClicked(relationship as string); };

                edgeGlyph.Width -= 24;
                edgeGlyph.Height-= 8;

                edgeGlyph.ToolTipOpening += EdgeToolTipOpening;
                this.Relationships.Children.Add(edgeGlyph);
            }
        }

        private async void EdgeToolTipOpening(object sender, ToolTipEventArgs e)
        {
            var container = sender as Button;
            var relationshipGlyph = container.Content as string;
            var relationship = relationshipGlyph.Replace("-[", "");
            relationship = relationship.Replace("]-", "");

            var query = string.Format("match ()-[c:{0}]-() return count(c) as Count", relationship);
            var result = await Model.ExecuteCypherAsync(query);

            container.ToolTip = string.Format("Database contains {0} instances", result[0].Values["Count"]);
        }

        private async void LabelTooltipOpening(object sender, ToolTipEventArgs e)
        {
            var chip = sender as MaterialDesignThemes.Wpf.Chip;
            var label = chip.Content as string;

            var query = string.Format("match(c:{0}) return count(c) as Count", label);
            var result = await Model.ExecuteCypherAsync(query);

            chip.ToolTip = string.Format("Database contains {0} instances", result[0].Values["Count"]);
        }

        private void LabelClicked(string label)
        {
            var query = string.Format("match (a:{0}) -[r]- (b) return * limit 30", label);
            this.ViewModel.EnterSourceInCypherEditor(query);
        }

        private void EdgeClicked(string edge)
        {
            var query = string.Format("match (a) -[r:{0}]- (b) return * limit 30", edge);
            this.ViewModel.EnterSourceInCypherEditor(query);
        }
    }
}
