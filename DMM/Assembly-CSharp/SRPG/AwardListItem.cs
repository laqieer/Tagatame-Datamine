// Decompiled with JetBrains decompiler
// Type: SRPG.AwardListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002079")]
  [AddComponentMenu("UI/AwardListItem")]
  public class AwardListItem : MonoBehaviour
  {
    [Token(Token = "0x4008BEB")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Image BackGround;
    [Token(Token = "0x4008BEC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text AwardName;
    [Token(Token = "0x4008BED")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject Cursor;
    [Token(Token = "0x4008BEE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject Badge;
    [Token(Token = "0x4008BEF")]
    [FieldOffset(Offset = "0x0")]
    public static readonly string EXTRA_GRADE_IMAGEPATH;
    [Token(Token = "0x4008BF0")]
    [FieldOffset(Offset = "0x4")]
    public static readonly int MAX_GRADE;
    [Token(Token = "0x4008BF1")]
    [FieldOffset(Offset = "0x1C")]
    private string mAwardIname;
    [Token(Token = "0x4008BF2")]
    [FieldOffset(Offset = "0x20")]
    private bool mIsSelected;
    [Token(Token = "0x4008BF3")]
    [FieldOffset(Offset = "0x21")]
    private bool mHasItem;
    [Token(Token = "0x4008BF4")]
    [FieldOffset(Offset = "0x22")]
    private bool mIsRefresh;
    [Token(Token = "0x4008BF5")]
    [FieldOffset(Offset = "0x23")]
    private bool mRemove;
    [Token(Token = "0x4008BF6")]
    [FieldOffset(Offset = "0x24")]
    private GameManager gm;

    [Token(Token = "0x600871F")]
    [Address(RVA = "0x484E20", Offset = "0x483C20", VA = "0x10484E20")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008720")]
    [Address(RVA = "0x4857D0", Offset = "0x4845D0", VA = "0x104857D0")]
    private void Update()
    {
    }

    [Token(Token = "0x6008721")]
    [Address(RVA = "0x485750", Offset = "0x484550", VA = "0x10485750")]
    public void SetUp(string iname, bool hasItem = false, bool selected = false, bool remove = false)
    {
    }

    [Token(Token = "0x6008722")]
    [Address(RVA = "0x485090", Offset = "0x483E90", VA = "0x10485090")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008723")]
    [Address(RVA = "0x484FD0", Offset = "0x483DD0", VA = "0x10484FD0")]
    private AwardParam CreateRemoveAwardData() => (AwardParam) null;

    [Token(Token = "0x6008724")]
    [Address(RVA = "0x485600", Offset = "0x484400", VA = "0x10485600")]
    private bool SetExtraAwardImage(string bg) => new bool();

    [Token(Token = "0x6008725")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AwardListItem()
    {
    }

    [Token(Token = "0x6008726")]
    [Address(RVA = "0x485800", Offset = "0x484600", VA = "0x10485800")]
    static AwardListItem()
    {
    }
  }
}
