using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlavorTexter
{
    internal static class Verber
    {
        public static string GetVerb(bool destructive = false)
        {
            var verb = "";
            if (!destructive)
            {
                verb += ConstructiveVerbs[Random.Shared.Next(0, ConstructiveVerbs.Length - 1)];
            }
            else
            {
                verb += DestructiveVerbs[Random.Shared.Next(0, DestructiveVerbs.Length - 1)];
            }
            verb += "ing";
            return verb;
        }

        public static string[] ConstructiveVerbs = new string[]
        {
            "Align",
            "Build",
            "Calibrat",
            "Instanc",
            "Configur",
            "Snort",
            "Microwav",
            "Tweak",
            "Wrangl",
            "Hack",
            
            "Pwn",
            "Boot",
            "Allocat",
            "Bind",
            "Revv",
            "Polish",
            "Fabricat",
            "Ping",
            "Refactor",
            "Load",
            
            "Quantify",
            "Assembl",
            "Distill",
            "Bak",
            "Receiv",
            "Unlock",
            "Compil",
            "Pressuriz",
            "Chooch",
            "Mak",
            
            "Engag",
            "Decrypt",
            "Synthesiz",
            "Predict",
            "Analyz",
            "Dispens",
            "Fir",
            "Insert",
            "Align",
            "Encourag",
            
            "Extrud",
            "Access",
            "Sharpen",
            "Enhanc",
            "Crank",
            "Stack",
            "Craft",
            "Render",
            "Mount",
            "Generat",
            
            "Implement",
            "Download",
            "Construct",
            "Wow! Amaz",
            "Moisten",
            "Customiz",
            "Compensat",
            "Buffer",
            "Transferr",
            "Induct",
            
            "Emitt",
            "Unzipp",
            "Squirt",
            "Feed",
            "Buy",
            "Spark",
            "Implant",
            "Triangulat",
            "Inject",
            "Link",
            "Brew",
            
            "Process",
            "Deploy",
            "Tun",
            "Attach",
            "Train",
            "Ignor",
            "Tapp",
            "Reload",
            "Simulat",
            "Fluff",
            
            "Fill",
            "Sort",
            "Updat",
            "Upgrad",
            "Prim",
            "Trac",
            "Inflat",
            "Wangjangl",
            "Charg",
            "Crack",
            
            "Ignor",
            "Activat",
            "Dial",
            "Pimp",
            "Collect",
            "Approach",
            "Approv",
            "Sampl",
            "Energiz",
            "Stuff"
        };

        public static string[] DestructiveVerbs = new string[] {
            "Deallocat",
            "Trash",
            "Unplugg",
            "Revok",
            "Forgett",
            "Discard",
            "Dropp",
            "Holster",
            "Shredd",
            "Jettison",
            
            "Dissolv",
            "Liquidat",
            "Releas",
            "Collimat",
            "Eject",
            "Ditch",
            "Leak",
            "Sell",
            "Banish",
            "Dereferenc",
            
            "Sacrific",
            "Desolder",
            "Destruct",
            "Decompil",
            "Blow",
            "Disengag",
            "Digest",
            "Smash",
            "Encrypt",
            "Crash",
            
            "Lock",
            "Purg",
            "Regrett",
            "Rewind",
            "Free",
            "Delet",
            "Clos",
            "Retract",
            "Collaps",
            "Liquefy",
            
            "Derezz",
            "Stow",
            "Archiv",
            "Suspend",
            "Suppress",
            "Clean",
            "Squash",
            "Secur",
            "Withdraw",
            "Dump",
            
            "Obfuscat",
            "Break",
            "Scrubb",
            "Abandon",
            "Flatten",
            "Stash",
            "Finish",
            "Evacuat",
            "Scrambl",
            "Recycl",
            
            "Crush",
            "Zipp",
            "Unload",
            "Disconnect",
            "Loosen",
            "Contain",
            "Debat",
            "Detach",
            "Neutraliz",
            "Salvag",
            
            "Empty",
            "Hid",
            "Disarm",
            "Pickl",
            "Disregard",
            "Yeet",
            "Scrapp",
            "Deflat",
            "Discharg",
            "Deactivat",
            
            "Steriliz",
            "Reliev",
            "Nuk",
            "Degauss",
            "Dismiss",
            "Drain",
            "Reject",
            "Nerf",
            "Pay",
            "Return",
            
            "Unstick",
            "Splitt",
            "Cancell",
            "Sham",
            "Embezzl",
            "Fling",
            "Regrett",
            "Halt",
            "Arrest",
            "Bury"
        };

    }
}
