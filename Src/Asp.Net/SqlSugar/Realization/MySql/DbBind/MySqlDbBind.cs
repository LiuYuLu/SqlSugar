﻿using System;
using System.Collections.Generic;

namespace SqlSugar
{
    public class MySqlDbBind : DbBindProvider
    {
        public override List<KeyValuePair<string, CSharpDataType>> MappingTypes
        {
            get
            {
                return new List<KeyValuePair<string, CSharpDataType>>()
                {
                    new KeyValuePair<string, CSharpDataType>("tinyint",CSharpDataType.@byte),
                    new KeyValuePair<string, CSharpDataType>("smallint",CSharpDataType.@short),
                    new KeyValuePair<string, CSharpDataType>("mediumint",CSharpDataType.@int),
                    new KeyValuePair<string, CSharpDataType>("int",CSharpDataType.@int),
                    new KeyValuePair<string, CSharpDataType>("integer",CSharpDataType.@int),
                    new KeyValuePair<string, CSharpDataType>("bigint",CSharpDataType.@long),
                    new KeyValuePair<string, CSharpDataType>("bit",CSharpDataType.@bool),
                    new KeyValuePair<string, CSharpDataType>("real",CSharpDataType.@double),
                    new KeyValuePair<string, CSharpDataType>("double",CSharpDataType.@double),
                    new KeyValuePair<string, CSharpDataType>("float",CSharpDataType.@float),
                    new KeyValuePair<string, CSharpDataType>("decimal",CSharpDataType.@decimal),
                    new KeyValuePair<string, CSharpDataType>("numeric",CSharpDataType.@decimal),
                    new KeyValuePair<string, CSharpDataType>("char",CSharpDataType.@string),
                    new KeyValuePair<string, CSharpDataType>("varchar",CSharpDataType.@string),
                    new KeyValuePair<string, CSharpDataType>("date",CSharpDataType.DateTime),
                    new KeyValuePair<string, CSharpDataType>("time",CSharpDataType.DateTime),
                    new KeyValuePair<string, CSharpDataType>("year",CSharpDataType.@int),
                    new KeyValuePair<string, CSharpDataType>("timestamp",CSharpDataType.DateTime),
                    new KeyValuePair<string, CSharpDataType>("datetime",CSharpDataType.DateTime),
                    new KeyValuePair<string, CSharpDataType>("tinyblob",CSharpDataType.byteArray),
                    new KeyValuePair<string, CSharpDataType>("blob",CSharpDataType.byteArray),
                    new KeyValuePair<string, CSharpDataType>("varbinary",CSharpDataType.byteArray),
                    new KeyValuePair<string, CSharpDataType>("binary",CSharpDataType.byteArray),
                    new KeyValuePair<string, CSharpDataType>("multipoint",CSharpDataType.byteArray),
                    new KeyValuePair<string, CSharpDataType>("geometry",CSharpDataType.byteArray),
                    new KeyValuePair<string, CSharpDataType>("multilinestring",CSharpDataType.byteArray),
                    new KeyValuePair<string, CSharpDataType>("polygon",CSharpDataType.byteArray),
                    new KeyValuePair<string, CSharpDataType>("enum",CSharpDataType.@string),
                    new KeyValuePair<string, CSharpDataType>("text",CSharpDataType.@string),
                };
            }
        }
    }
}