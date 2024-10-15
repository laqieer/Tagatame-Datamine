// Decompiled with JetBrains decompiler
// Type: SRPG.AlchemyShopManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200251D")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "初期化完了", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "ショップリストがない", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(111, "カテゴリが選択された", FlowNode.PinTypes.Output, 111)]
  [AddComponentMenu("UI/Guild/AlchemyShopManager")]
  public class AlchemyShopManager : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A9AA")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject WindowCategory;
    [Token(Token = "0x400A9AB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject WindowShop;
    [Token(Token = "0x400A9AC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    [Space(5f)]
    private GameObject GoCategoryParent;
    [Token(Token = "0x400A9AD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private AlchemyShopItemCategory TemplateCategory;
    [Token(Token = "0x400A9AE")]
    [FieldOffset(Offset = "0x1C")]
    [Space(5f)]
    [SerializeField]
    private ScrollRect SrControllerShop;
    [Token(Token = "0x400A9AF")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400A9B0")]
    private const int PIN_OUT_INIT_FINISHED = 101;
    [Token(Token = "0x400A9B1")]
    private const int PIN_OUT_NO_SHOP_LIST = 102;
    [Token(Token = "0x400A9B2")]
    private const int PIN_OUT_CATEGORY_SELECTED = 111;
    [Token(Token = "0x400A9B3")]
    [FieldOffset(Offset = "0x0")]
    private static AlchemyShopManager mInstance;
    [Token(Token = "0x400A9B4")]
    [FieldOffset(Offset = "0x20")]
    private JSON_ShopListArray.Shops[] mShopArray;
    [Token(Token = "0x400A9B5")]
    [FieldOffset(Offset = "0x24")]
    private LimitedShopListItemInfo mShopInfo;

    [Token(Token = "0x170016C3")]
    public static AlchemyShopManager Instance
    {
      [Token(Token = "0x600A31E"), Address(RVA = "0x643630", Offset = "0x642430", VA = "0x10643630")] get
      {
        return (AlchemyShopManager) null;
      }
    }

    [Token(Token = "0x600A31F")]
    [Address(RVA = "0x642850", Offset = "0x641650", VA = "0x10642850")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A320")]
    [Address(RVA = "0x643110", Offset = "0x641F10", VA = "0x10643110")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A321")]
    [Address(RVA = "0x642F10", Offset = "0x641D10", VA = "0x10642F10")]
    private void InternalClearGlobalLimitedShopItemInfo()
    {
    }

    [Token(Token = "0x600A322")]
    [Address(RVA = "0x642B10", Offset = "0x641910", VA = "0x10642B10")]
    private void Init()
    {
    }

    [Token(Token = "0x600A323")]
    [Address(RVA = "0x6433F0", Offset = "0x6421F0", VA = "0x106433F0")]
    private bool SetGlobalVarsShopData(JSON_ShopListArray.Shops shop) => new bool();

    [Token(Token = "0x600A324")]
    [Address(RVA = "0x6430F0", Offset = "0x641EF0", VA = "0x106430F0")]
    private bool IsExistShopList() => new bool();

    [Token(Token = "0x600A325")]
    [Address(RVA = "0x643050", Offset = "0x641E50", VA = "0x10643050")]
    private bool IsExistLimitedShopData() => new bool();

    [Token(Token = "0x600A326")]
    [Address(RVA = "0x6431B0", Offset = "0x641FB0", VA = "0x106431B0")]
    private void OnTapCategoryItem(AlchemyShopItemCategory item)
    {
    }

    [Token(Token = "0x600A327")]
    [Address(RVA = "0x642770", Offset = "0x641570", VA = "0x10642770", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A328")]
    [Address(RVA = "0x6429D0", Offset = "0x6417D0", VA = "0x106429D0")]
    public static bool EntryShopList(JSON_ShopListArray.Shops[] shops) => new bool();

    [Token(Token = "0x600A329")]
    [Address(RVA = "0x642950", Offset = "0x641750", VA = "0x10642950")]
    public static void ClearGlobalLimitedShopItemInfo()
    {
    }

    [Token(Token = "0x600A32A")]
    [Address(RVA = "0x643300", Offset = "0x642100", VA = "0x10643300")]
    public static bool SetCurrentShopData(Json_LimitedShopResponse shop_data) => new bool();

    [Token(Token = "0x600A32B")]
    [Address(RVA = "0x642A60", Offset = "0x641860", VA = "0x10642A60")]
    public static int GetShopListIndex(JSON_ShopListArray.Shops shop) => new int();

    [Token(Token = "0x600A32C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AlchemyShopManager()
    {
    }
  }
}
