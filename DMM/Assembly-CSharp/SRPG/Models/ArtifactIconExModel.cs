// Decompiled with JetBrains decompiler
// Type: SRPG.Models.ArtifactIconExModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200330A")]
  public class ArtifactIconExModel
  {
    [Token(Token = "0x400F051")]
    [FieldOffset(Offset = "0x8")]
    private ArtifactParam mParam;
    [Token(Token = "0x400F052")]
    [FieldOffset(Offset = "0xC")]
    private ArtifactData mData;
    [Token(Token = "0x400F053")]
    [FieldOffset(Offset = "0x10")]
    public bool IsDispOwner_Arena;
    [Token(Token = "0x400F054")]
    [FieldOffset(Offset = "0x11")]
    public bool IsDispOwner_Support;
    [Token(Token = "0x400F055")]
    [FieldOffset(Offset = "0x12")]
    public bool IsDispOwner_GvG;
    [Token(Token = "0x400F056")]
    [FieldOffset(Offset = "0x13")]
    public bool IsDispOwner_LeagueMatch;
    [Token(Token = "0x400F057")]
    [FieldOffset(Offset = "0x14")]
    public bool ForceMask;
    [Token(Token = "0x400F058")]
    [FieldOffset(Offset = "0x15")]
    public bool EquipForceMask;
    [Token(Token = "0x400F059")]
    [FieldOffset(Offset = "0x18")]
    public ArtifactIconExModel.InstanceTypes InstanceType;
    [Token(Token = "0x400F05A")]
    [FieldOffset(Offset = "0x1C")]
    public int DeriveTriggerIndex;
    [Token(Token = "0x400F05B")]
    [FieldOffset(Offset = "0x20")]
    private string mIconPath;
    [Token(Token = "0x400F05C")]
    [FieldOffset(Offset = "0x24")]
    private bool mRarityUpBackEnabled;
    [Token(Token = "0x400F05D")]
    [FieldOffset(Offset = "0x25")]
    private bool mDefaultBackEnabled;
    [Token(Token = "0x400F05E")]
    [FieldOffset(Offset = "0x26")]
    private bool mCanCreateBackEnabled;
    [Token(Token = "0x400F05F")]
    [FieldOffset(Offset = "0x27")]
    private bool mCanCreateGaugeEnabled;
    [Token(Token = "0x400F060")]
    [FieldOffset(Offset = "0x28")]
    private Color mNotCreateGrayIconColor;
    [Token(Token = "0x400F061")]
    [FieldOffset(Offset = "0x38")]
    private Color mNotCreateGrayRawIconColor;
    [Token(Token = "0x400F062")]
    [FieldOffset(Offset = "0x48")]
    private string mLv;
    [Token(Token = "0x400F063")]
    [FieldOffset(Offset = "0x4C")]
    private string mPreLvCap;
    [Token(Token = "0x400F064")]
    [FieldOffset(Offset = "0x50")]
    private string mLvCap;
    [Token(Token = "0x400F065")]
    [FieldOffset(Offset = "0x54")]
    private int mLvGaugeMin;
    [Token(Token = "0x400F066")]
    [FieldOffset(Offset = "0x58")]
    private int mLvGaugeMax;
    [Token(Token = "0x400F067")]
    [FieldOffset(Offset = "0x5C")]
    private int mLvGaugeValue;
    [Token(Token = "0x400F068")]
    [FieldOffset(Offset = "0x60")]
    private int mExpGaugeMin;
    [Token(Token = "0x400F069")]
    [FieldOffset(Offset = "0x64")]
    private int mExpGaugeMax;
    [Token(Token = "0x400F06A")]
    [FieldOffset(Offset = "0x68")]
    private int mExpGaugeValue;
    [Token(Token = "0x400F06B")]
    [FieldOffset(Offset = "0x6C")]
    private int mPieceGaugeMin;
    [Token(Token = "0x400F06C")]
    [FieldOffset(Offset = "0x70")]
    private int mPieceGaugeMax;
    [Token(Token = "0x400F06D")]
    [FieldOffset(Offset = "0x74")]
    private int mPieceGaugeValue;
    [Token(Token = "0x400F06E")]
    [FieldOffset(Offset = "0x78")]
    private string mRarityUpCost;
    [Token(Token = "0x400F06F")]
    [FieldOffset(Offset = "0x7C")]
    private string mTransmuteCost;
    [Token(Token = "0x400F070")]
    [FieldOffset(Offset = "0x80")]
    private string mPieceNum;
    [Token(Token = "0x400F071")]
    [FieldOffset(Offset = "0x84")]
    private Color mPieceNumColor;
    [Token(Token = "0x400F072")]
    [FieldOffset(Offset = "0x94")]
    private Sprite mRarity;
    [Token(Token = "0x400F073")]
    [FieldOffset(Offset = "0x98")]
    private Sprite mRarityMax;
    [Token(Token = "0x400F074")]
    [FieldOffset(Offset = "0x9C")]
    private string mRarityText;
    [Token(Token = "0x400F075")]
    [FieldOffset(Offset = "0xA0")]
    private string mRarityMaxText;
    [Token(Token = "0x400F076")]
    [FieldOffset(Offset = "0xA4")]
    private Sprite mFrame;
    [Token(Token = "0x400F077")]
    [FieldOffset(Offset = "0xA8")]
    private Sprite mCategory;
    [Token(Token = "0x400F078")]
    [FieldOffset(Offset = "0xAC")]
    private string mDecKakeraNum;
    [Token(Token = "0x400F079")]
    [FieldOffset(Offset = "0xB0")]
    private string mDecCost;
    [Token(Token = "0x400F07A")]
    [FieldOffset(Offset = "0xB4")]
    private Sprite mOwnerIcon;
    [Token(Token = "0x400F07B")]
    [FieldOffset(Offset = "0xB8")]
    private int mLastLv;
    [Token(Token = "0x400F07C")]
    [FieldOffset(Offset = "0xBC")]
    private int mLastLvCap;
    [Token(Token = "0x400F07D")]
    [FieldOffset(Offset = "0xC0")]
    private int mLastExpNum;
    [Token(Token = "0x400F07E")]
    [FieldOffset(Offset = "0xC4")]
    private int mRarityIndex;
    [Token(Token = "0x400F07F")]
    [FieldOffset(Offset = "0xC8")]
    private int mRarityMaxIndex;
    [Token(Token = "0x400F080")]
    [FieldOffset(Offset = "0xCC")]
    private bool mIsInspirarion;
    [Token(Token = "0x400F081")]
    [FieldOffset(Offset = "0xCD")]
    private bool mIsStoneEffectOpen;
    [Token(Token = "0x400F082")]
    [FieldOffset(Offset = "0xCE")]
    private bool mIsIncludeOverWrite;
    [Token(Token = "0x400F083")]
    [FieldOffset(Offset = "0xD0")]
    private Dictionary<ArtifactIconExModel.VisibleKey, bool> mVisibleInternalDic;
    [Token(Token = "0x400F084")]
    [FieldOffset(Offset = "0xD4")]
    private Dictionary<ArtifactIconExModel.VisibleKey, bool> mVisibleExternalDic;

    [Token(Token = "0x17001D55")]
    public ArtifactData Data
    {
      [Token(Token = "0x600E053"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (ArtifactData) null;
      }
    }

    [Token(Token = "0x17001D56")]
    public ArtifactParam Param
    {
      [Token(Token = "0x600E054"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (ArtifactParam) null;
      }
    }

    [Token(Token = "0x600E055")]
    [Address(RVA = "0xAA6970", Offset = "0xAA5770", VA = "0x10AA6970")]
    public bool Visible(ArtifactIconExModel.VisibleKey key) => new bool();

    [Token(Token = "0x17001D57")]
    public string IconPath
    {
      [Token(Token = "0x600E056"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D58")]
    public bool RarityUpBackEnabled
    {
      [Token(Token = "0x600E057"), Address(RVA = "0x2A5A90", Offset = "0x2A4890", VA = "0x102A5A90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001D59")]
    public bool DefaultBackEnabled
    {
      [Token(Token = "0x600E058"), Address(RVA = "0x628F10", Offset = "0x627D10", VA = "0x10628F10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001D5A")]
    public bool CanCreateBackEnabled
    {
      [Token(Token = "0x600E059"), Address(RVA = "0xAA6C30", Offset = "0xAA5A30", VA = "0x10AA6C30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001D5B")]
    public bool CanCreateGaugeEnabled
    {
      [Token(Token = "0x600E05A"), Address(RVA = "0xAA6C40", Offset = "0xAA5A40", VA = "0x10AA6C40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001D5C")]
    public Color NotCreateGrayIconColor
    {
      [Token(Token = "0x600E05B"), Address(RVA = "0xAA6C50", Offset = "0xAA5A50", VA = "0x10AA6C50")] get
      {
        return new Color();
      }
    }

    [Token(Token = "0x17001D5D")]
    public Color NotCreateGrayRawIconColor
    {
      [Token(Token = "0x600E05C"), Address(RVA = "0x305790", Offset = "0x304590", VA = "0x10305790")] get
      {
        return new Color();
      }
    }

    [Token(Token = "0x17001D5E")]
    public string Lv
    {
      [Token(Token = "0x600E05D"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D5F")]
    public string PreLvCap
    {
      [Token(Token = "0x600E05E"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D60")]
    public string LvCap
    {
      [Token(Token = "0x600E05F"), Address(RVA = "0x3490F0", Offset = "0x347EF0", VA = "0x103490F0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D61")]
    public int LvGaugeMin
    {
      [Token(Token = "0x600E060"), Address(RVA = "0x349170", Offset = "0x347F70", VA = "0x10349170")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D62")]
    public int LvGaugeMax
    {
      [Token(Token = "0x600E061"), Address(RVA = "0x349160", Offset = "0x347F60", VA = "0x10349160")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D63")]
    public int LvGaugeValue
    {
      [Token(Token = "0x600E062"), Address(RVA = "0x288090", Offset = "0x286E90", VA = "0x10288090")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D64")]
    public int ExpGaugeMin
    {
      [Token(Token = "0x600E063"), Address(RVA = "0x2B5EA0", Offset = "0x2B4CA0", VA = "0x102B5EA0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D65")]
    public int ExpGaugeMax
    {
      [Token(Token = "0x600E064"), Address(RVA = "0x2B6040", Offset = "0x2B4E40", VA = "0x102B6040")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D66")]
    public int ExpGaugeValue
    {
      [Token(Token = "0x600E065"), Address(RVA = "0x349350", Offset = "0x348150", VA = "0x10349350")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D67")]
    public int PieceGaugeMin
    {
      [Token(Token = "0x600E066"), Address(RVA = "0x288AC0", Offset = "0x2878C0", VA = "0x10288AC0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D68")]
    public int PieceGaugeMax
    {
      [Token(Token = "0x600E067"), Address(RVA = "0x288AD0", Offset = "0x2878D0", VA = "0x10288AD0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D69")]
    public int PieceGaugeValue
    {
      [Token(Token = "0x600E068"), Address(RVA = "0x349360", Offset = "0x348160", VA = "0x10349360")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D6A")]
    public string RarityUpCost
    {
      [Token(Token = "0x600E069"), Address(RVA = "0x349370", Offset = "0x348170", VA = "0x10349370")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D6B")]
    public string TransmuteCost
    {
      [Token(Token = "0x600E06A"), Address(RVA = "0x2B5EF0", Offset = "0x2B4CF0", VA = "0x102B5EF0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D6C")]
    public string PieceNum
    {
      [Token(Token = "0x600E06B"), Address(RVA = "0x3197C0", Offset = "0x3185C0", VA = "0x103197C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D6D")]
    public Color PieceNumColor
    {
      [Token(Token = "0x600E06C"), Address(RVA = "0xAA6C70", Offset = "0xAA5A70", VA = "0x10AA6C70")] get
      {
        return new Color();
      }
    }

    [Token(Token = "0x17001D6E")]
    public Sprite Rarity
    {
      [Token(Token = "0x600E06D"), Address(RVA = "0x349020", Offset = "0x347E20", VA = "0x10349020")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x17001D6F")]
    public Sprite RarityMax
    {
      [Token(Token = "0x600E06E"), Address(RVA = "0x289A70", Offset = "0x288870", VA = "0x10289A70")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x17001D70")]
    public string RarityText
    {
      [Token(Token = "0x600E06F"), Address(RVA = "0x37DBB0", Offset = "0x37C9B0", VA = "0x1037DBB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D71")]
    public string RarityMaxText
    {
      [Token(Token = "0x600E070"), Address(RVA = "0x511530", Offset = "0x510330", VA = "0x10511530")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D72")]
    public Sprite Frame
    {
      [Token(Token = "0x600E071"), Address(RVA = "0x4601D0", Offset = "0x45EFD0", VA = "0x104601D0")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x17001D73")]
    public Sprite Category
    {
      [Token(Token = "0x600E072"), Address(RVA = "0x4601C0", Offset = "0x45EFC0", VA = "0x104601C0")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x17001D74")]
    public string DecKakeraNum
    {
      [Token(Token = "0x600E073"), Address(RVA = "0x349120", Offset = "0x347F20", VA = "0x10349120")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D75")]
    public string DecCost
    {
      [Token(Token = "0x600E074"), Address(RVA = "0x5FC000", Offset = "0x5FAE00", VA = "0x105FC000")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D76")]
    public Sprite OwnerIcon
    {
      [Token(Token = "0x600E075"), Address(RVA = "0x305C10", Offset = "0x304A10", VA = "0x10305C10")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x17001D77")]
    public int LastLv
    {
      [Token(Token = "0x600E076"), Address(RVA = "0x3E1690", Offset = "0x3E0490", VA = "0x103E1690")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D78")]
    public int LastLvCap
    {
      [Token(Token = "0x600E077"), Address(RVA = "0x36AA10", Offset = "0x369810", VA = "0x1036AA10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D79")]
    public int LastExpNum
    {
      [Token(Token = "0x600E078"), Address(RVA = "0x5FC060", Offset = "0x5FAE60", VA = "0x105FC060")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600E079")]
    [Address(RVA = "0xAA6A00", Offset = "0xAA5800", VA = "0x10AA6A00")]
    public ArtifactIconExModel()
    {
    }

    [Token(Token = "0x600E07A")]
    [Address(RVA = "0xAA4680", Offset = "0xAA3480", VA = "0x10AA4680")]
    public void InitRarityParam()
    {
    }

    [Token(Token = "0x600E07B")]
    [Address(RVA = "0xAA4A40", Offset = "0xAA3840", VA = "0x10AA4A40")]
    public void Initialize(ArtifactParam artifactParam, bool isVisibleInit = true)
    {
    }

    [Token(Token = "0x600E07C")]
    [Address(RVA = "0xAA5CA0", Offset = "0xAA4AA0", VA = "0x10AA5CA0")]
    public void SetupParam()
    {
    }

    [Token(Token = "0x600E07D")]
    [Address(RVA = "0xAA57F0", Offset = "0xAA45F0", VA = "0x10AA57F0")]
    public void SetupIcon()
    {
    }

    [Token(Token = "0x600E07E")]
    [Address(RVA = "0xAA5370", Offset = "0xAA4170", VA = "0x10AA5370")]
    public void SetupCreate()
    {
    }

    [Token(Token = "0x600E07F")]
    [Address(RVA = "0xAA6890", Offset = "0xAA5690", VA = "0x10AA6890")]
    public void SetupTransmuteCost()
    {
    }

    [Token(Token = "0x600E080")]
    [Address(RVA = "0xAA6490", Offset = "0xAA5290", VA = "0x10AA6490")]
    public void SetupPiece()
    {
    }

    [Token(Token = "0x600E081")]
    [Address(RVA = "0xAA6310", Offset = "0xAA5110", VA = "0x10AA6310")]
    public void SetupPieceGuage()
    {
    }

    [Token(Token = "0x600E082")]
    [Address(RVA = "0xAA6760", Offset = "0xAA5560", VA = "0x10AA6760")]
    public void SetupRarity()
    {
    }

    [Token(Token = "0x600E083")]
    [Address(RVA = "0xAA6600", Offset = "0xAA5400", VA = "0x10AA6600")]
    public void SetupRarityFrame()
    {
    }

    [Token(Token = "0x600E084")]
    [Address(RVA = "0xAA4D60", Offset = "0xAA3B60", VA = "0x10AA4D60")]
    private void SetCategoryIcon()
    {
    }

    [Token(Token = "0x600E085")]
    [Address(RVA = "0xAA49D0", Offset = "0xAA37D0", VA = "0x10AA49D0")]
    public void Initialize(ArtifactData artifactData)
    {
    }

    [Token(Token = "0x600E086")]
    [Address(RVA = "0xAA5520", Offset = "0xAA4320", VA = "0x10AA5520")]
    public void SetupData()
    {
    }

    [Token(Token = "0x600E087")]
    [Address(RVA = "0xAA5880", Offset = "0xAA4680", VA = "0x10AA5880")]
    public void SetupLevel()
    {
    }

    [Token(Token = "0x600E088")]
    [Address(RVA = "0xAA6700", Offset = "0xAA5500", VA = "0x10AA6700")]
    public void SetupRarityUp()
    {
    }

    [Token(Token = "0x600E089")]
    [Address(RVA = "0xAA5090", Offset = "0xAA3E90", VA = "0x10AA5090")]
    private void SetIsRarityMax()
    {
    }

    [Token(Token = "0x600E08A")]
    [Address(RVA = "0xAA5280", Offset = "0xAA4080", VA = "0x10AA5280")]
    private void SetRarityUpCost()
    {
    }

    [Token(Token = "0x600E08B")]
    [Address(RVA = "0xAA51B0", Offset = "0xAA3FB0", VA = "0x10AA51B0")]
    private bool SetOwner() => new bool();

    [Token(Token = "0x600E08C")]
    [Address(RVA = "0xAA4A90", Offset = "0xAA3890", VA = "0x10AA4A90")]
    private bool ResearchOwnerIcon(GameManager gm, ArtifactData data) => new bool();

    [Token(Token = "0x600E08D")]
    [Address(RVA = "0xAA4FB0", Offset = "0xAA3DB0", VA = "0x10AA4FB0")]
    private bool SetFavorite(bool lockMaskVisible) => new bool();

    [Token(Token = "0x600E08E")]
    [Address(RVA = "0xAA5180", Offset = "0xAA3F80", VA = "0x10AA5180")]
    private void SetLockMask(bool lockMaskVisible)
    {
    }

    [Token(Token = "0x600E08F")]
    [Address(RVA = "0xAA4F00", Offset = "0xAA3D00", VA = "0x10AA4F00")]
    private void SetEquipLockMask()
    {
    }

    [Token(Token = "0x600E090")]
    [Address(RVA = "0xAA5150", Offset = "0xAA3F50", VA = "0x10AA5150")]
    private void SetLastExpNum()
    {
    }

    [Token(Token = "0x600E091")]
    [Address(RVA = "0xAA4EA0", Offset = "0xAA3CA0", VA = "0x10AA4EA0")]
    private void SetDecKakeraNum()
    {
    }

    [Token(Token = "0x600E092")]
    [Address(RVA = "0xAA4E40", Offset = "0xAA3C40", VA = "0x10AA4E40")]
    private void SetDecCost()
    {
    }

    [Token(Token = "0x600E093")]
    [Address(RVA = "0xAA4F00", Offset = "0xAA3D00", VA = "0x10AA4F00")]
    public void SetupOther()
    {
    }

    [Token(Token = "0x600E094")]
    [Address(RVA = "0xAA4760", Offset = "0xAA3560", VA = "0x10AA4760")]
    public void InitVisible(
      Dictionary<ArtifactIconExModel.VisibleKey, bool> visibleDic,
      bool isDefault = false)
    {
    }

    [Token(Token = "0x600E095")]
    [Address(RVA = "0xAA52E0", Offset = "0xAA40E0", VA = "0x10AA52E0")]
    public void SetVisible(
      Dictionary<ArtifactIconExModel.VisibleKey, bool> visibleDic,
      ArtifactIconExModel.VisibleKey key,
      bool isFlag)
    {
    }

    [Token(Token = "0x600E096")]
    [Address(RVA = "0xAA5000", Offset = "0xAA3E00", VA = "0x10AA5000")]
    public void SetInternalVisible(ArtifactIconExModel.VisibleKey key, bool isFlag)
    {
    }

    [Token(Token = "0x600E097")]
    [Address(RVA = "0xAA4F20", Offset = "0xAA3D20", VA = "0x10AA4F20")]
    public void SetExternalVisible(ArtifactIconExModel.VisibleKey key, bool isFlag)
    {
    }

    [Token(Token = "0x200330B")]
    public enum SetType
    {
      [Token(Token = "0x400F086")] Param,
      [Token(Token = "0x400F087")] Data,
    }

    [Token(Token = "0x200330C")]
    public enum InstanceTypes
    {
      [Token(Token = "0x400F089")] ArtifactData,
      [Token(Token = "0x400F08A")] ArtifactParam,
      [Token(Token = "0x400F08B")] SkillAbilityDeriveParam,
      [Token(Token = "0x400F08C")] ArtifactDataOrParam,
    }

    [Token(Token = "0x200330D")]
    public enum VisibleKey
    {
      [Token(Token = "0x400F08E")] Icon,
      [Token(Token = "0x400F08F")] Rarity,
      [Token(Token = "0x400F090")] RarityMax,
      [Token(Token = "0x400F091")] RarityText,
      [Token(Token = "0x400F092")] RarityMaxText,
      [Token(Token = "0x400F093")] Frame,
      [Token(Token = "0x400F094")] Lv,
      [Token(Token = "0x400F095")] LvCap,
      [Token(Token = "0x400F096")] PreLvCap,
      [Token(Token = "0x400F097")] LvGauge,
      [Token(Token = "0x400F098")] ExpGauge,
      [Token(Token = "0x400F099")] PieceGauge,
      [Token(Token = "0x400F09A")] Category,
      [Token(Token = "0x400F09B")] Owner,
      [Token(Token = "0x400F09C")] OwnerIcon,
      [Token(Token = "0x400F09D")] DecCost,
      [Token(Token = "0x400F09E")] DecKakeraNum,
      [Token(Token = "0x400F09F")] TransmuteCost,
      [Token(Token = "0x400F0A0")] NotRarityUp,
      [Token(Token = "0x400F0A1")] CanRarityUp,
      [Token(Token = "0x400F0A2")] IndexBadge,
      [Token(Token = "0x400F0A3")] RarityUp,
      [Token(Token = "0x400F0A4")] CanCreate,
      [Token(Token = "0x400F0A5")] RarityUpBack,
      [Token(Token = "0x400F0A6")] CanCreateBack,
      [Token(Token = "0x400F0A7")] CanCreateGauge,
      [Token(Token = "0x400F0A8")] DefaultGauge,
      [Token(Token = "0x400F0A9")] DefaultBack,
      [Token(Token = "0x400F0AA")] RarityUpCost,
      [Token(Token = "0x400F0AB")] PieceNum,
      [Token(Token = "0x400F0AC")] NotCreateGrayIcon,
      [Token(Token = "0x400F0AD")] NotCreateGrayRawIcon,
      [Token(Token = "0x400F0AE")] Favorite,
      [Token(Token = "0x400F0AF")] LockMask,
      [Token(Token = "0x400F0B0")] EquipLockMask,
    }
  }
}
