// Decompiled with JetBrains decompiler
// Type: SRPG.AppealItemLimitedShop
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
  [Token(Token = "0x2001FC9")]
  [AddComponentMenu("UI/AppealItemLimitedShop")]
  public class AppealItemLimitedShop : AppealItemBase
  {
    [Token(Token = "0x40086B5")]
    [FieldOffset(Offset = "0x14")]
    private readonly string SPRITES_PATH;
    [Token(Token = "0x40086B6")]
    [FieldOffset(Offset = "0x18")]
    private readonly string MASTER_PATH;
    [Token(Token = "0x40086B7")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Image AppealChara;
    [Token(Token = "0x40086B8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform AppealCharaRect;
    [Token(Token = "0x40086B9")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Image AppealTextL;
    [Token(Token = "0x40086BA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image AppealTextR;
    [Token(Token = "0x40086BB")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private RectTransform AppealTextRect;
    [Token(Token = "0x40086BC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button LimitedShopButton;
    [Token(Token = "0x40086BD")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject LockObject;
    [Token(Token = "0x40086BE")]
    [FieldOffset(Offset = "0x38")]
    private string mAppealID;
    [Token(Token = "0x40086BF")]
    [FieldOffset(Offset = "0x3C")]
    private float mPosX_Chara;
    [Token(Token = "0x40086C0")]
    [FieldOffset(Offset = "0x40")]
    private float mPosX_Text;
    [Token(Token = "0x40086C1")]
    [FieldOffset(Offset = "0x44")]
    private bool IsLoaded;
    [Token(Token = "0x40086C2")]
    [FieldOffset(Offset = "0x45")]
    private bool mIsInitialized;
    [Token(Token = "0x40086C3")]
    [FieldOffset(Offset = "0x48")]
    private Sprite CharaSprite;
    [Token(Token = "0x40086C4")]
    [FieldOffset(Offset = "0x4C")]
    private Sprite TextLSprite;
    [Token(Token = "0x40086C5")]
    [FieldOffset(Offset = "0x50")]
    private Sprite TextRSprite;

    [Token(Token = "0x170012CD")]
    public bool IsInitialized
    {
      [Token(Token = "0x60082EA"), Address(RVA = "0x2AA800", Offset = "0x2A9600", VA = "0x102AA800")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60082EB")]
    [Address(RVA = "0x436B30", Offset = "0x435930", VA = "0x10436B30", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x60082EC")]
    [Address(RVA = "0x437410", Offset = "0x436210", VA = "0x10437410", Slot = "5")]
    protected override void Start()
    {
    }

    [Token(Token = "0x60082ED")]
    [Address(RVA = "0x437590", Offset = "0x436390", VA = "0x10437590", Slot = "6")]
    protected override void Update()
    {
    }

    [Token(Token = "0x60082EE")]
    [Address(RVA = "0x437120", Offset = "0x435F20", VA = "0x10437120", Slot = "9")]
    protected override void Refresh()
    {
    }

    [Token(Token = "0x60082EF")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
    protected override void Destroy()
    {
    }

    [Token(Token = "0x60082F0")]
    [Address(RVA = "0x436D00", Offset = "0x435B00", VA = "0x10436D00")]
    private bool LoadAppealMaster(string path) => new bool();

    [Token(Token = "0x60082F1")]
    [Address(RVA = "0x4370B0", Offset = "0x435EB0", VA = "0x104370B0")]
    private IEnumerator LoadAppealResourcess(string path) => (IEnumerator) null;

    [Token(Token = "0x60082F2")]
    [Address(RVA = "0x4375C0", Offset = "0x4363C0", VA = "0x104375C0")]
    public AppealItemLimitedShop()
    {
    }
  }
}
