(: Copyright (c) Microsoft Corporation.
   Licensed under the MIT license. :)

(: Extract some query metadata in CSV format :)
(: @Category Informational :)
(: @Language Xpp :)
(: @Author pvillads@microsoft.com :)

let $options := map { 'lax': false(), 'header': true() }

let $r := <Queries>
{
    for $t in /Query
    return <Record>
        <Package>{lower-case($t/@Package)}</Package>
        <Artifact>{lower-case($t/@Artifact)}</Artifact>
        <Name>{lower-case($t/@Name)}</Name>
        <Title>{lower-case($t/Metadata/Title/data())}</Title>
    </Record>
}
</Queries>

return csv:serialize($r, $options)
