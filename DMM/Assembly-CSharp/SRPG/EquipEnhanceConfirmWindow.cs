// Decompiled with JetBrains decompiler
// Type: SRPG.EquipEnhanceConfirmWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200235C")]
  [AddComponentMenu("UI/EquipEnhanceConfirmWindow")]
  public class EquipEnhanceConfirmWindow : MonoBehaviour
  {
    [Token(Token = "0x4009E79")]
    private const int PIN_OUT_CLOSE = 0;
    [Token(Token = "0x4009E7A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mTemplateItem;
    [Token(Token = "0x4009E7B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mCostErrorObj;
    [Token(Token = "0x4009E7C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mCostText;
    [Token(Token = "0x4009E7D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button mSelectButton;
    [Token(Token = "0x4009E7E")]
    [FieldOffset(Offset = "0x1C")]
    public EquipEnhanceConfirmWindow.OnEnhanceSelectedEvent OnSelectedEvent;
    [Token(Token = "0x4009E7F")]
    [FieldOffset(Offset = "0x20")]
    public EquipEnhanceConfirmWindow.OnEnhanceSelectedEvent OnCanceledEvent;

    [Token(Token = "0x6009868")]
    [Address(RVA = "0x5B0540", Offset = "0x5AF340", VA = "0x105B0540")]
    public void OnDecide()
    {
    }

    [Token(Token = "0x6009869")]
    [Address(RVA = "0x5B0520", Offset = "0x5AF320", VA = "0x105B0520")]
    public void OnCancel()
    {
    }

    [Token(Token = "0x600986A")]
    [Address(RVA = "0x5B06C0", Offset = "0x5AF4C0", VA = "0x105B06C0")]
    public void SetupItem(ItemData list, int num)
    {
    }

    [Token(Token = "0x600986B")]
    [Address(RVA = "0x5B0560", Offset = "0x5AF360", VA = "0x105B0560")]
    public void SetupCost(int cost)
    {
    }

    [Token(Token = "0x600986C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public EquipEnhanceConfirmWindow()
    {
    }

    [Token(Token = "0x200235D")]
    public delegate void OnEnhanceSelectedEvent();
  }
}
