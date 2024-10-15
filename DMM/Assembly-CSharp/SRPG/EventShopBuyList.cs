// Decompiled with JetBrains decompiler
// Type: SRPG.EventShopBuyList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002381")]
  [AddComponentMenu("UI/EventShopBuyList")]
  public class EventShopBuyList : MonoBehaviour, IWebHelp
  {
    [Token(Token = "0x4009FDE")]
    [FieldOffset(Offset = "0xC")]
    public GameObject amount;
    [Token(Token = "0x4009FDF")]
    [FieldOffset(Offset = "0x10")]
    public GameObject day_reset;
    [Token(Token = "0x4009FE0")]
    [FieldOffset(Offset = "0x14")]
    public GameObject limit;
    [Token(Token = "0x4009FE1")]
    [FieldOffset(Offset = "0x18")]
    public GameObject icon_set;
    [Token(Token = "0x4009FE2")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject sold_count;
    [Token(Token = "0x4009FE3")]
    [FieldOffset(Offset = "0x20")]
    public GameObject no_limited_price;
    [Token(Token = "0x4009FE4")]
    [FieldOffset(Offset = "0x24")]
    public Text amount_text;
    [Token(Token = "0x4009FE5")]
    [FieldOffset(Offset = "0x28")]
    public Button self_button;
    [Token(Token = "0x4009FE6")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject image_price_sold_count;
    [Token(Token = "0x4009FE7")]
    [FieldOffset(Offset = "0x30")]
    public GameObject image_price_sold_count_infinite;
    [Token(Token = "0x4009FE8")]
    [FieldOffset(Offset = "0x34")]
    public GameObject unit_have_purchase;
    [Token(Token = "0x4009FE9")]
    [FieldOffset(Offset = "0x38")]
    [HeaderBar("▼アイテム表示用")]
    public GameObject item_name;
    [Token(Token = "0x4009FEA")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject item_icon;
    [Token(Token = "0x4009FEB")]
    [FieldOffset(Offset = "0x40")]
    [HeaderBar("▼武具表示用")]
    public GameObject artifact_name;
    [Token(Token = "0x4009FEC")]
    [FieldOffset(Offset = "0x44")]
    public GameObject artifact_icon;
    [Token(Token = "0x4009FED")]
    [FieldOffset(Offset = "0x48")]
    [HeaderBar("▼真理念装表示用")]
    public GameObject conceptCard_name;
    [Token(Token = "0x4009FEE")]
    [FieldOffset(Offset = "0x4C")]
    public ConceptCardIcon conceptCard_icon;
    [Token(Token = "0x4009FEF")]
    [FieldOffset(Offset = "0x50")]
    [HeaderBar("▼水晶表示用")]
    public Text crystal_name;
    [Token(Token = "0x4009FF0")]
    [FieldOffset(Offset = "0x54")]
    public CrystalIcon crystal_icon;
    [Token(Token = "0x4009FF1")]
    [FieldOffset(Offset = "0x58")]
    public GameObject crystalHelp;
    [Token(Token = "0x4009FF2")]
    [FieldOffset(Offset = "0x5C")]
    private string crystalWebID;
    [Token(Token = "0x4009FF3")]
    [FieldOffset(Offset = "0x60")]
    [Space(10f)]
    public GameObject TimeLimitBase;
    [Token(Token = "0x4009FF4")]
    [FieldOffset(Offset = "0x64")]
    public GameObject TimeLimitPopup;
    [Token(Token = "0x4009FF5")]
    [FieldOffset(Offset = "0x68")]
    public Text TimeLimitText;
    [Token(Token = "0x4009FF6")]
    [FieldOffset(Offset = "0x6C")]
    private float mRefreshInterval;
    [Token(Token = "0x4009FF7")]
    [FieldOffset(Offset = "0x70")]
    private long mEndTime;
    [Token(Token = "0x4009FF8")]
    [FieldOffset(Offset = "0x78")]
    private string mDayLimit;
    [Token(Token = "0x4009FF9")]
    [FieldOffset(Offset = "0x7C")]
    private string mHourLimit;
    [Token(Token = "0x4009FFA")]
    [FieldOffset(Offset = "0x80")]
    private string mMinuteLimit;
    [Token(Token = "0x4009FFB")]
    [FieldOffset(Offset = "0x84")]
    private EventShopItem mEventShopItem;

    [Token(Token = "0x6009970")]
    [Address(RVA = "0x5D93B0", Offset = "0x5D81B0", VA = "0x105D93B0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009971")]
    [Address(RVA = "0x5D9BF0", Offset = "0x5D89F0", VA = "0x105D9BF0")]
    private void Update()
    {
    }

    [Token(Token = "0x6009972")]
    [Address(RVA = "0x5D9520", Offset = "0x5D8320", VA = "0x105D9520")]
    private void Refresh()
    {
    }

    [Token(Token = "0x17001560")]
    public EventShopItem eventShopItem
    {
      [Token(Token = "0x6009973"), Address(RVA = "0x5D9C90", Offset = "0x5D8A90", VA = "0x105D9C90")] set
      {
      }
      [Token(Token = "0x6009974"), Address(RVA = "0x2B6020", Offset = "0x2B4E20", VA = "0x102B6020")] get
      {
        return (EventShopItem) null;
      }
    }

    [Token(Token = "0x6009975")]
    [Address(RVA = "0x5D99F0", Offset = "0x5D87F0", VA = "0x105D99F0")]
    public void SetupConceptCard(ConceptCardData conceptCardData)
    {
    }

    [Token(Token = "0x6009976")]
    [Address(RVA = "0x5D9A60", Offset = "0x5D8860", VA = "0x105D9A60")]
    public void SetupCrystal(CrystalData _data, CrystalParam _param, string webId)
    {
    }

    [Token(Token = "0x6009977")]
    [Address(RVA = "0x5D9B50", Offset = "0x5D8950", VA = "0x105D9B50")]
    public void SetupWebURL(string webId)
    {
    }

    [Token(Token = "0x6009978")]
    [Address(RVA = "0x5D9470", Offset = "0x5D8270", VA = "0x105D9470", Slot = "4")]
    public bool GetHelpURL(out string url, out string title) => new bool();

    [Token(Token = "0x6009979")]
    [Address(RVA = "0x5D9C40", Offset = "0x5D8A40", VA = "0x105D9C40")]
    public EventShopBuyList()
    {
    }
  }
}
