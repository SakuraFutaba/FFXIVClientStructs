using UserFileEvent = FFXIVClientStructs.FFXIV.Client.UI.Misc.UserFileManager.UserFileEvent;

namespace FFXIVClientStructs.FFXIV.Client.UI.Misc;

// Client::UI::Misc::UiSavePackModule
//   Client::UI::Misc::UserFileManager::UserFileEvent
[GenerateInterop]
[Inherits<UserFileEvent>]
[StructLayout(LayoutKind.Explicit, Size = 0x58)]
public unsafe partial struct UiSavePackModule {
    public static UiSavePackModule* Instance() {
        var uiModule = UIModule.Instance();
        return uiModule == null ? null : uiModule->GetUiSavePackModule();
    }

    [VirtualFunction(14)]
    public partial nint GetSegment(byte segment);

    public nint GetSegment(DataSegment segment) => GetSegment((byte)segment);
}

public enum DataSegment : byte {
    LETTER = 0x00, // Ingame Mail
    RETTASK = 0x01,
    FLAGS = 0x02,
    RCFAV = 0x03,
    UIDATA = 0x04,
    TLPH = 0x05,
    ITCC = 0x06,
    PVPSET = 0x07,
    EMTH = 0x08,
    MNONLST = 0x09,
    MUNTLST = 0x0A,
    EMJ = 0x0B,
    AOZNOTE = 0x0C,
    CWLS = 0x0D,
    ARCHVLST = 0x0E,
    GRPPOS = 0x0F,
    CRAFT = 0x10,
    FMARKER = 0x11,
    MYCNOT = 0x12,
    ORNMLST = 0x13,
    MYCITEM = 0x14,
    GRPSTAMP = 0x15,
    RTNR = 0x16,
    BANNER = 0x17,
    ADVNOTE = 0x18,
    AKTKNOT = 0x19,
    VVDNOTE = 0x1A,
    VVDACT = 0x1B,
    TOFU = 0x1C,
    FISHING = 0x1D,
    ACTION = 0x1E,
    TFILTER = 0x1F,
    READYC = 0x20,
    PTRLST = 0x21,
    CATSBM = 0x22,
    DESCRI = 0x23,
    MJICWSP = 0x24,
    PERFORM = 0x25,
}
