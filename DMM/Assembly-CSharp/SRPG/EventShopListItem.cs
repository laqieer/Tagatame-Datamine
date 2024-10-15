// Decompiled with JetBrains decompiler
// Type: SRPG.EventShopListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002396")]
  [AddComponentMenu("UI/EventShopListItem")]
  public class EventShopListItem : MonoBehaviour
  {
    [Token(Token = "0x400A06C")]
    [FieldOffset(Offset = "0xC")]
    public LText l_text;
    [Token(Token = "0x400A06D")]
    [FieldOffset(Offset = "0x10")]
    public GameObject Body;
    [Token(Token = "0x400A06E")]
    [FieldOffset(Offset = "0x14")]
    public Text Timer;
    [Token(Token = "0x400A06F")]
    [FieldOffset(Offset = "0x18")]
    private long mEndTime;
    [Token(Token = "0x400A070")]
    [FieldOffset(Offset = "0x20")]
    private float mRefreshInterval;
    [Token(Token = "0x400A071")]
    [FieldOffset(Offset = "0x24")]
    public Image banner;
    [Token(Token = "0x400A072")]
    [FieldOffset(Offset = "0x28")]
    public string EventShopSpritePath;
    [Token(Token = "0x400A073")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject mPaidCoinIcon;
    [Token(Token = "0x400A074")]
    [FieldOffset(Offset = "0x30")]
    public GameObject mPaidCoinNum;
    [Token(Token = "0x400A075")]
    [FieldOffset(Offset = "0x34")]
    public GameObject mLockObject;
    [Token(Token = "0x400A076")]
    [FieldOffset(Offset = "0x38")]
    public Text mLockText;
    [Token(Token = "0x400A077")]
    [FieldOffset(Offset = "0x3C")]
    public EventShopInfo EventShopInfo;
    [Token(Token = "0x400A078")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private string[] HIDE_TIME_LIMIT_SHOP_NAMES;

    [Token(Token = "0x60099D2")]
    [Address(RVA = "0x5E1650", Offset = "0x5E0450", VA = "0x105E1650")]
    private void Start()
    {
    }

    [Token(Token = "0x60099D3")]
    [Address(RVA = "0x5E18A0", Offset = "0x5E06A0", VA = "0x105E18A0")]
    private void Update()
    {
    }

    [Token(Token = "0x60099D4")]
    [Address(RVA = "0x5E1150", Offset = "0x5DFF50", VA = "0x105E1150")]
    public void SetShopList(JSON_ShopListArray.Shops shops, Json_ShopMsgResponse msg)
    {
    }

    [Token(Token = "0x60099D5")]
    [Address(RVA = "0x5E0CB0", Offset = "0x5DFAB0", VA = "0x105E0CB0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x60099D6")]
    [Address(RVA = "0x5E17C0", Offset = "0x5E05C0", VA = "0x105E17C0")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x60099D7")]
    [Address(RVA = "0x5E18F0", Offset = "0x5E06F0", VA = "0x105E18F0")]
    public EventShopListItem()
    {
    }
  }
}
