// Decompiled with JetBrains decompiler
// Type: SRPG.AppealItemEventShop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FBE")]
  [AddComponentMenu("UI/AppealItemEventShop")]
  public class AppealItemEventShop : AppealItemBase
  {
    [Token(Token = "0x400867B")]
    [FieldOffset(Offset = "0x14")]
    private readonly string SPRITES_PATH;
    [Token(Token = "0x400867C")]
    [FieldOffset(Offset = "0x18")]
    private readonly string MASTER_PATH;
    [Token(Token = "0x400867D")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Image AppealChara;
    [Token(Token = "0x400867E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform AppealCharaRect;
    [Token(Token = "0x400867F")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Image AppealTextL;
    [Token(Token = "0x4008680")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image AppealTextR;
    [Token(Token = "0x4008681")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private RectTransform AppealTextRect;
    [Token(Token = "0x4008682")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private SRPG_Button EventShopButton;
    [Token(Token = "0x4008683")]
    [FieldOffset(Offset = "0x34")]
    private string mAppealID;
    [Token(Token = "0x4008684")]
    [FieldOffset(Offset = "0x38")]
    private float mPosX_Chara;
    [Token(Token = "0x4008685")]
    [FieldOffset(Offset = "0x3C")]
    private float mPosX_Text;
    [Token(Token = "0x4008686")]
    [FieldOffset(Offset = "0x40")]
    private bool IsLoaded;
    [Token(Token = "0x4008687")]
    [FieldOffset(Offset = "0x41")]
    private bool IsInitalize;
    [Token(Token = "0x4008688")]
    [FieldOffset(Offset = "0x44")]
    private Sprite CharaSprite;
    [Token(Token = "0x4008689")]
    [FieldOffset(Offset = "0x48")]
    private Sprite TextLSprite;
    [Token(Token = "0x400868A")]
    [FieldOffset(Offset = "0x4C")]
    private Sprite TextRSprite;

    [Token(Token = "0x60082C6")]
    [Address(RVA = "0x435040", Offset = "0x433E40", VA = "0x10435040", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x60082C7")]
    [Address(RVA = "0x4358D0", Offset = "0x4346D0", VA = "0x104358D0", Slot = "5")]
    protected override void Start()
    {
    }

    [Token(Token = "0x60082C8")]
    [Address(RVA = "0x4359E0", Offset = "0x4347E0", VA = "0x104359E0", Slot = "6")]
    protected override void Update()
    {
    }

    [Token(Token = "0x60082C9")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
    protected override void Destroy()
    {
    }

    [Token(Token = "0x60082CA")]
    [Address(RVA = "0x435620", Offset = "0x434420", VA = "0x10435620", Slot = "9")]
    protected override void Refresh()
    {
    }

    [Token(Token = "0x60082CB")]
    [Address(RVA = "0x435200", Offset = "0x434000", VA = "0x10435200")]
    private bool LoadAppealMaster(string path) => new bool();

    [Token(Token = "0x60082CC")]
    [Address(RVA = "0x4355B0", Offset = "0x4343B0", VA = "0x104355B0")]
    private IEnumerator LoadAppealResources(string path) => (IEnumerator) null;

    [Token(Token = "0x60082CD")]
    [Address(RVA = "0x435A10", Offset = "0x434810", VA = "0x10435A10")]
    public AppealItemEventShop()
    {
    }
  }
}
