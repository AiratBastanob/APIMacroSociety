using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppMacroSociety.Models
{
    public partial class ListMusicUser
    {
        public int Id { get; set; }
        public string NameUser { get; set; }
        public string Music1 { get; set; }
        public string Music2 { get; set; }
        public string Music3 { get; set; }
        public string Music4 { get; set; }
        public string Music5 { get; set; }
        public string Music6 { get; set; }
        public string Music7 { get; set; }
        public string Music8 { get; set; }
        public string Music9 { get; set; }
        public string Music10 { get; set; }
        public string Music11 { get; set; }
        public string Music12 { get; set; }
        public string Music13 { get; set; }
        public string Music14 { get; set; }
        public string Music15 { get; set; }
        public string Music16 { get; set; }
        public string Music17 { get; set; }
        public string Music18 { get; set; }
        public string Music19 { get; set; }
        public string Music20 { get; set; }
        public string Music21 { get; set; }
        public string Music22 { get; set; }
        public string Music23 { get; set; }
        public string Music24 { get; set; }
        public string Music25 { get; set; }
        public string UserReceivedMusicPrize { get; set; }
        public int IdUser { get; set; }

        public virtual User IdUserNavigation { get; set; }
    }
}
