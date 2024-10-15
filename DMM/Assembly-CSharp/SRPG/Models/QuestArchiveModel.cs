// Decompiled with JetBrains decompiler
// Type: SRPG.Models.QuestArchiveModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200337D")]
  public class QuestArchiveModel
  {
    [Token(Token = "0x400F396")]
    [FieldOffset(Offset = "0x8")]
    private ArchiveParam _archiveParam;
    [Token(Token = "0x400F397")]
    [FieldOffset(Offset = "0xC")]
    private ItemData _keyItemData;
    [Token(Token = "0x400F398")]
    [FieldOffset(Offset = "0x10")]
    private ChapterParam _chapterParam;
    [Token(Token = "0x400F399")]
    [FieldOffset(Offset = "0x14")]
    private List<ChapterParam> _chapterParamList;
    [Token(Token = "0x400F39A")]
    [FieldOffset(Offset = "0x18")]
    private OpenedQuestArchive _openedQuestArchive;
    [Token(Token = "0x400F39B")]
    [FieldOffset(Offset = "0x1C")]
    private AdvanceEventParam _advanceEventParam;
    [Token(Token = "0x400F39C")]
    [FieldOffset(Offset = "0x20")]
    private UnitParam _unit1Param;
    [Token(Token = "0x400F39D")]
    [FieldOffset(Offset = "0x24")]
    private UnitParam _unit2Param;
    [Token(Token = "0x400F39E")]
    [FieldOffset(Offset = "0x28")]
    private bool _isNoMission;
    [Token(Token = "0x400F39F")]
    [FieldOffset(Offset = "0x29")]
    private bool _missionComplete;
    [Token(Token = "0x400F3A0")]
    [FieldOffset(Offset = "0x2C")]
    private BaseItemModel _baseItemModel;
    [Token(Token = "0x400F3A1")]
    [FieldOffset(Offset = "0x30")]
    private int _itemNum;
    [Token(Token = "0x400F3A2")]
    private const int freeOpenCount = 1;
    [Token(Token = "0x400F3A3")]
    private const int archiveItemCount = 3;

    [Token(Token = "0x17001F92")]
    public ArchiveParam ArchiveData
    {
      [Token(Token = "0x600E4F4"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (ArchiveParam) null;
      }
    }

    [Token(Token = "0x17001F93")]
    public ChapterParam ChapterData
    {
      [Token(Token = "0x600E4F5"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (ChapterParam) null;
      }
    }

    [Token(Token = "0x17001F94")]
    public List<ChapterParam> ChapterDataList
    {
      [Token(Token = "0x600E4F6"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<ChapterParam>) null;
      }
    }

    [Token(Token = "0x17001F95")]
    public OpenedQuestArchive OpenedQuestArchiveData
    {
      [Token(Token = "0x600E4F7"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (OpenedQuestArchive) null;
      }
    }

    [Token(Token = "0x17001F96")]
    public AdvanceEventParam AdvanceEventData
    {
      [Token(Token = "0x600E4F8"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (AdvanceEventParam) null;
      }
    }

    [Token(Token = "0x17001F97")]
    public UnitParam Unit1Param
    {
      [Token(Token = "0x600E4F9"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (UnitParam) null;
      }
    }

    [Token(Token = "0x17001F98")]
    public UnitParam Unit2Param
    {
      [Token(Token = "0x600E4FA"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (UnitParam) null;
      }
    }

    [Token(Token = "0x17001F99")]
    public ItemData KeyItemData
    {
      [Token(Token = "0x600E4FB"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (ItemData) null;
      }
    }

    [Token(Token = "0x17001F9A")]
    public BaseItemModel ItemModel
    {
      [Token(Token = "0x600E4FC"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (BaseItemModel) null;
      }
    }

    [Token(Token = "0x17001F9B")]
    public string QuestName
    {
      [Token(Token = "0x600E4FD"), Address(RVA = "0xABF720", Offset = "0xABE520", VA = "0x10ABF720")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F9C")]
    public bool IsDetailsButton
    {
      [Token(Token = "0x600E4FE"), Address(RVA = "0xABF590", Offset = "0xABE390", VA = "0x10ABF590")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F9D")]
    public string FreeCountMassage
    {
      [Token(Token = "0x600E4FF"), Address(RVA = "0xABF470", Offset = "0xABE270", VA = "0x10ABF470")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F9E")]
    public bool IsArchiveFree
    {
      [Token(Token = "0x600E500"), Address(RVA = "0xABF580", Offset = "0xABE380", VA = "0x10ABF580")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F9F")]
    public string KeyItemMessage
    {
      [Token(Token = "0x600E501"), Address(RVA = "0xABF5B0", Offset = "0xABE3B0", VA = "0x10ABF5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001FA0")]
    public bool MissionComplete
    {
      [Token(Token = "0x600E502"), Address(RVA = "0x3550A0", Offset = "0x353EA0", VA = "0x103550A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001FA1")]
    public bool IsNoMission
    {
      [Token(Token = "0x600E503"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001FA2")]
    public List<ArchiveItemsParam> ArchiveItemList
    {
      [Token(Token = "0x600E504"), Address(RVA = "0xABF3B0", Offset = "0xABE1B0", VA = "0x10ABF3B0")] get
      {
        return (List<ArchiveItemsParam>) null;
      }
    }

    [Token(Token = "0x17001FA3")]
    public int ItemNum
    {
      [Token(Token = "0x600E505"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600E506")]
    [Address(RVA = "0xABEBC0", Offset = "0xABD9C0", VA = "0x10ABEBC0")]
    public void Initialize(ArchiveParam archive)
    {
    }

    [Token(Token = "0x600E507")]
    [Address(RVA = "0xABEB90", Offset = "0xABD990", VA = "0x10ABEB90")]
    private void InitializeData()
    {
    }

    [Token(Token = "0x600E508")]
    [Address(RVA = "0xABEFA0", Offset = "0xABDDA0", VA = "0x10ABEFA0")]
    private void SetKeyItemData()
    {
    }

    [Token(Token = "0x600E509")]
    [Address(RVA = "0xABEC00", Offset = "0xABDA00", VA = "0x10ABEC00")]
    private void SetArchiveData()
    {
    }

    [Token(Token = "0x600E50A")]
    [Address(RVA = "0xABE910", Offset = "0xABD710", VA = "0x10ABE910")]
    private string GetFreeCountMessage() => (string) null;

    [Token(Token = "0x600E50B")]
    [Address(RVA = "0xABE7B0", Offset = "0xABD5B0", VA = "0x10ABE7B0")]
    private bool GetArchiveFree() => new bool();

    [Token(Token = "0x600E50C")]
    [Address(RVA = "0xABEA20", Offset = "0xABD820", VA = "0x10ABEA20")]
    private string GetKeyItemMessage() => (string) null;

    [Token(Token = "0x600E50D")]
    [Address(RVA = "0xABF160", Offset = "0xABDF60", VA = "0x10ABF160")]
    private void SetMissionState()
    {
    }

    [Token(Token = "0x600E50E")]
    [Address(RVA = "0xABE850", Offset = "0xABD650", VA = "0x10ABE850")]
    private List<ArchiveItemsParam> GetArchiveItems() => (List<ArchiveItemsParam>) null;

    [Token(Token = "0x600E50F")]
    [Address(RVA = "0xABF390", Offset = "0xABE190", VA = "0x10ABF390")]
    public QuestArchiveModel()
    {
    }
  }
}
