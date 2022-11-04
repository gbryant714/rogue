using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogue.Records
{
    public class ItemRecord
    {
        public int ItemId { get; set; }
        public int GearSlot { get; set; }
        public string? Name {  get; set; }
        public int[]? DamageRange { get; set; }
        public int? Dps { get; set; }
        public string? Range { get; set; }
        public int[]? RawStats { get; set; }
        public string? Equip { get; set; }
        public string? OnUse { get; set; }
        public bool? IsEnchanted { get; set; }
        public bool? IsGemmed { get; set; }
        public string? Enchant { get; set; }
        public string? Gem { get; set; }
    }
}
