// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureTimeItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FB4")]
  [AddComponentMenu("UI/Adventure/AdventureTimeItem")]
  public class AdventureTimeItem : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008648")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text AdventureItemEffectText;
    [Token(Token = "0x4008649")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text Amount;
    [Token(Token = "0x400864A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Slider SilderData;
    [Token(Token = "0x400864B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SRPG_Button SilderPlusBtn;
    [Token(Token = "0x400864C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SRPG_Button SilderMinusBtn;
    [Token(Token = "0x400864D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Toggle MaxToggleBtn;
    [Token(Token = "0x400864E")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text UseNumText;
    [Token(Token = "0x400864F")]
    [FieldOffset(Offset = "0x28")]
    private AdventureItemParam mAdItemParam;
    [Token(Token = "0x4008650")]
    [FieldOffset(Offset = "0x2C")]
    private ItemParam mItemParam;
    [Token(Token = "0x4008651")]
    [FieldOffset(Offset = "0x30")]
    private ItemData mItemData;

    [Token(Token = "0x170012C5")]
    public AdventureItemParam AdItemParam
    {
      [Token(Token = "0x600829A"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (AdventureItemParam) null;
      }
    }

    [Token(Token = "0x600829B")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600829C")]
    [Address(RVA = "0x433A60", Offset = "0x432860", VA = "0x10433A60")]
    public void SetUp(
      AdventureSaveTimeItem _save_time_item,
      AdventureItemParam _ad_item_param,
      ItemData item_data)
    {
    }

    [Token(Token = "0x600829D")]
    [Address(RVA = "0x4339B0", Offset = "0x4327B0", VA = "0x104339B0")]
    public AdventureSaveTimeItem.UseItemData CreateSliderData()
    {
      return (AdventureSaveTimeItem.UseItemData) null;
    }

    [Token(Token = "0x600829E")]
    [Address(RVA = "0x433C90", Offset = "0x432A90", VA = "0x10433C90")]
    public void SetUseNumText(int num)
    {
    }

    [Token(Token = "0x600829F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdventureTimeItem()
    {
    }
  }
}
