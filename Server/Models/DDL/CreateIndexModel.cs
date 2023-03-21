﻿using Server.Models.Catalog;
using System.Text.RegularExpressions;

namespace Server.Models.DDL
{
    public class CreateIndexModel
    {
        public string IndexName { get; set; }
        public string TableName { get; set; }
        public List<string> Attributes { get; set; }

        public CreateIndexModel(string indexName, string tableName, List<string> attributes)
        {
            IndexName = indexName;
            TableName= tableName;
            Attributes = attributes;
        }

        public static CreateIndexModel FromMatch(Match match)
        {
            string indexName = match.Groups["IndexName"].Value;
            string tableName = match.Groups["TableName"].Value;
            List<string> attributes = new();

            foreach (Capture column in match.Groups["Column"].Captures)
            {
                attributes.Add(column.Value);
            }

            return new CreateIndexModel(indexName, tableName, attributes);
        }

        public IndexFile ToIndexFile()
        {
            return new()
            {
                IndexFileName = IndexName,
                AttributeNames = Attributes,
            };
        }
    }
}
