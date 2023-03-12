﻿using Server.Models.DDL;
using Server.Parser.Actions;
using Server.Utils;
using System.Text.RegularExpressions;

namespace Server.Parser.DDL
{
    internal class CreateTable : BaseDbAction
    {    
        public CreateTableModel Model { get; private set; }

        public CreateTable(Match match)
        {
            this.Model = CreateTableModel.FromMatch(match);
        }

        public override void PerformAction()
        {
            // TO-DO: Create Table in MongoDB

            XML<CreateTableModel>.InsertObjIntoXML(Model, "table", "databases", $"{Model.TableName}.xml");

            Messages.Add($"Table {Model.TableName} successfully created!");
        }
    }
}
