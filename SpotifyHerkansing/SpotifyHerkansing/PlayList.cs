using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyHerkansing
{
    internal class PlayList : SongCollection
    {
        public int Id { get; set; }
        private Person owner;
        public Person Owner { get { return owner; } set { owner = value; } }

        public PlayList(Person owner, string Name) : base(Name)
        {
            this.owner = owner;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
