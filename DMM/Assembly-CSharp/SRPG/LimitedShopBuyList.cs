// Decompiled with JetBrains decompiler
// Type: SRPG.LimitedShopBuyList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026C6")]
  [AddComponentMenu("UI/LimitedShopBuyList")]
  public class LimitedShopBuyList : MonoBehaviour, IWebHelp
  {
    [Token(Token = "0x400B5FE")]
    [FieldOffset(Offset = "0xC")]
    public GameObject amount;
    [Token(Token = "0x400B5FF")]
    [FieldOffset(Offset = "0x10")]
    public GameObject day_reset;
    [Token(Token = "0x400B600")]
    [FieldOffset(Offset = "0x14")]
    public GameObject limit;
    [Token(Token = "0x400B601")]
    [FieldOffset(Offset = "0x18")]
    public GameObject icon_set;
    [Token(Token = "0x400B602")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject sold_count;
    [Token(Token = "0x400B603")]
    [FieldOffset(Offset = "0x20")]
    public GameObject no_limited_price;
    [Token(Token = "0x400B604")]
    [FieldOffset(Offset = "0x24")]
    public Text amount_text;
    [Token(Token = "0x400B605")]
    [FieldOffset(Offset = "0x28")]
    public Button self_button;
    [Token(Token = "0x400B606")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject image_price_sold_count;
    [Token(Token = "0x400B607")]
    [FieldOffset(Offset = "0x30")]
    public GameObject image_price_sold_count_infinite;
    [Token(Token = "0x400B608")]
    [FieldOffset(Offset = "0x34")]
    public GameObject unit_have_purchase;
    [Token(Token = "0x400B609")]
    [FieldOffset(Offset = "0x38")]
    [HeaderBar("▼アイテム表示用")]
    public GameObject item_name;
    [Token(Token = "0x400B60A")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject item_icon;
    [Token(Token = "0x400B60B")]
    [FieldOffset(Offset = "0x40")]
    [HeaderBar("▼武具表示用")]
    public GameObject artifact_name;
    [Token(Token = "0x400B60C")]
    [FieldOffset(Offset = "0x44")]
    public GameObject artifact_icon;
    [Token(Token = "0x400B60D")]
    [FieldOffset(Offset = "0x48")]
    [HeaderBar("▼真理念装表示用")]
    public GameObject conceptCard_name;
    [Token(Token = "0x400B60E")]
    [FieldOffset(Offset = "0x4C")]
    public ConceptCardIcon conceptCard_icon;
    [Token(Token = "0x400B60F")]
    [FieldOffset(Offset = "0x50")]
    [HeaderBar("▼水晶表示用")]
    public Text crystal_name;
    [Token(Token = "0x400B610")]
    [FieldOffset(Offset = "0x54")]
    public CrystalIcon crystal_icon;
    [Token(Token = "0x400B611")]
    [FieldOffset(Offset = "0x58")]
    public GameObject crystalHelp;
    [Token(Token = "0x400B612")]
    [FieldOffset(Offset = "0x5C")]
    private string crystalWebID;
    [Token(Token = "0x400B613")]
    [FieldOffset(Offset = "0x60")]
    [Space(10f)]
    public GameObject TimeLimitBase;
    [Token(Token = "0x400B614")]
    [FieldOffset(Offset = "0x64")]
    public GameObject TimeLimitPopup;
    [Token(Token = "0x400B615")]
    [FieldOffset(Offset = "0x68")]
    public Text TimeLimitText;
    [Token(Token = "0x400B616")]
    [FieldOffset(Offset = "0x6C")]
    private float mRefreshInterval;
    [Token(Token = "0x400B617")]
    [FieldOffset(Offset = "0x70")]
    private long mEndTime;
    [Token(Token = "0x400B618")]
    [FieldOffset(Offset = "0x78")]
    private string mDayLimit;
    [Token(Token = "0x400B619")]
    [FieldOffset(Offset = "0x7C")]
    private string mHourLimit;
    [Token(Token = "0x400B61A")]
    [FieldOffset(Offset = "0x80")]
    private string mMinuteLimit;
    [Token(Token = "0x400B61B")]
    [FieldOffset(Offset = "0x84")]
    private LimitedShopItem mLimitedShopItem;

    [Token(Token = "0x600AD90")]
    [Address(RVA = "0x715DC0", Offset = "0x714BC0", VA = "0x10715DC0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AD91")]
    [Address(RVA = "0x716600", Offset = "0x715400", VA = "0x10716600")]
    private void Update()
    {
    }

    [Token(Token = "0x600AD92")]
    [Address(RVA = "0x715F30", Offset = "0x714D30", VA = "0x10715F30")]
    private void Refresh()
    {
    }

    [Token(Token = "0x17001812")]
    public LimitedShopItem limitedShopItem
    {
      [Token(Token = "0x600AD93"), Address(RVA = "0x7166A0", Offset = "0x7154A0", VA = "0x107166A0")] set
      {
      }
      [Token(Token = "0x600AD94"), Address(RVA = "0x2B6020", Offset = "0x2B4E20", VA = "0x102B6020")] get
      {
        return (LimitedShopItem) null;
      }
    }

    [Token(Token = "0x600AD95")]
    [Address(RVA = "0x716400", Offset = "0x715200", VA = "0x10716400")]
    public void SetupConceptCard(ConceptCardData conceptCardData)
    {
    }

    [Token(Token = "0x600AD96")]
    [Address(RVA = "0x716470", Offset = "0x715270", VA = "0x10716470")]
    public void SetupCrystal(CrystalData _data, CrystalParam _param, string webId)
    {
    }

    [Token(Token = "0x600AD97")]
    [Address(RVA = "0x716560", Offset = "0x715360", VA = "0x10716560")]
    public void SetupWebURL(string webId)
    {
    }

    [Token(Token = "0x600AD98")]
    [Address(RVA = "0x715E80", Offset = "0x714C80", VA = "0x10715E80", Slot = "4")]
    public bool GetHelpURL(out string url, out string title) => new bool();

    [Token(Token = "0x600AD99")]
    [Address(RVA = "0x716650", Offset = "0x715450", VA = "0x10716650")]
    public LimitedShopBuyList()
    {
    }
  }
}
