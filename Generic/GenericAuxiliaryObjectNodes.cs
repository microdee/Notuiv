﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notui;
using VVVV.Nodes.Generic;
using VVVV.PluginInterfaces.V2;
using VVVV.Utils.Streams;

namespace Notuiv.Generic
{
    [PluginInfo(Name = "Cons",
                Category = "Notui.Auxiliary",
                Help = "Concatenates all Input spreads.",
                Tags = "generic, spreadop"
                )]
    public class AuxiliaryObjectConsNode : Cons<IAuxiliaryObject> { }

    [PluginInfo(Name = "CAR",
                Category = "Notui.Auxiliary",
                Version = "Bin",
                Help = "Splits a given spread into first slice and remainder.",
                Tags = "split, generic, spreadop",
                Author = "woei"
               )]
    public class AuxiliaryObjectCARBinNode : CARBin<IAuxiliaryObject> { }

    [PluginInfo(Name = "CDR",
                Category = "Notui.Auxiliary",
                Version = "Bin",
                Help = "Splits a given spread into remainder and last slice.",
                Tags = "split, generic, spreadop",
                Author = "woei"
               )]
    public class AuxiliaryObjectCDRBinNode : CDRBin<IAuxiliaryObject> { }

    [PluginInfo(Name = "Reverse",
                Category = "Notui.Auxiliary",
                Version = "Bin",
                Help = "Reverses the order of the slices in the Spread.",
                Tags = "invert, generic, spreadop",
                Author = "woei"
               )]
    public class AuxiliaryObjectReverseBinNode : ReverseBin<IAuxiliaryObject> { }

    [PluginInfo(Name = "Shift",
                Category = "Notui.Auxiliary",
                Version = "Bin",
                Help = "Shifts the slices in the Spread by the given Phase.",
                Tags = "generic, spreadop",
                Author = "woei"
               )]
    public class AuxiliaryObjectShiftBinNode : ShiftBin<IAuxiliaryObject> { }

    [PluginInfo(Name = "SetSlice",
                Category = "Notui.Auxiliary",
                Version = "Bin",
                Help = "Replaces individual slices of a spread with the given input",
                Tags = "generic, spreadop",
                Author = "woei"
               )]
    public class AuxiliaryObjectSetSliceNode : SetSlice<IAuxiliaryObject> { }

    [PluginInfo(Name = "DeleteSlice",
                Category = "Notui.Auxiliary",
                Help = "Removes slices from the Spread at the positions addressed by the Index pin.",
                Tags = "remove, generic, spreadop",
                Author = "woei"
               )]
    public class AuxiliaryObjectDeleteSliceNode : DeleteSlice<IAuxiliaryObject> { }

    [PluginInfo(Name = "Select",
                Category = "Notui.Auxiliary",
                Help = "Returns each slice of the Input spread as often as specified by the corresponding Select slice. 0 meaning the slice will be omitted. ",
                Tags = "repeat, resample, duplicate, spreadop"
               )]
    public class AuxiliaryObjectSelectNode : Select<IAuxiliaryObject> { }

    [PluginInfo(Name = "Select",
                Category = "Notui.Auxiliary",
                Version = "Bin",
                Help = "Returns each slice of the Input spread as often as specified by the corresponding Select slice. 0 meaning the slice will be omitted. ",
                Tags = "repeat, resample, duplicate, spreadop",
                Author = "woei"
            )]
    public class AuxiliaryObjectSelectBinNode : SelectBin<IAuxiliaryObject> { }

    [PluginInfo(Name = "Unzip",
                Category = "Notui.Auxiliary",
                Help = "The inverse of Zip. Interprets the Input spread as being interleaved and untangles it.",
                Tags = "split, generic, spreadop"
               )]
    public class AuxiliaryObjectUnzipNode : Unzip<IAuxiliaryObject> { }

    [PluginInfo(Name = "Unzip",
                Category = "Notui.Auxiliary",
                Version = "Bin",
                Help = "The inverse of Zip. Interprets the Input spread as being interleaved and untangles it. With Bin Size.",
                Tags = "split, generic, spreadop"
               )]
    public class AuxiliaryObjectUnzipBinNode : Unzip<IInStream<IAuxiliaryObject>> { }

    [PluginInfo(Name = "Zip",
                Category = "Notui.Auxiliary",
                Help = "Interleaves all Input spreads.",
                Tags = "interleave, join, generic, spreadop"
               )]
    public class AuxiliaryObjectZipNode : Zip<IAuxiliaryObject> { }

    [PluginInfo(Name = "Zip",
                Category = "Notui.Auxiliary",
                Version = "Bin",
                Help = "Interleaves all Input spreads.",
                Tags = "interleave, join, generic, spreadop"
               )]
    public class AuxiliaryObjectZipBinNode : Zip<IInStream<IAuxiliaryObject>> { }

    [PluginInfo(Name = "GetSpread",
                Category = "Notui.Auxiliary",
                Version = "Bin",
                Help = "Returns sub-spreads from the input specified via offset and count",
                Tags = "generic, spreadop",
                Author = "woei")]
    public class AuxiliaryObjectGetSpreadNode : GetSpreadAdvanced<IAuxiliaryObject> { }

    [PluginInfo(Name = "SetSpread",
                Category = "Notui.Auxiliary",
                Version = "Bin",
                Help = "Allows to set sub-spreads into a given spread.",
                Tags = "generic, spreadop",
                Author = "woei"
               )]
    public class AuxiliaryObjectSetSpreadNode : SetSpread<IAuxiliaryObject> { }

    [PluginInfo(Name = "SplitAt",
                Category = "Notui.Auxiliary",
                Help = "Splits the Input spread in two at the specified Index.",
                Tags = "generic, spreadop"
                )]
    public class AuxiliaryObjectSplitAtNode : SplitAtNode<IAuxiliaryObject> { }
}
