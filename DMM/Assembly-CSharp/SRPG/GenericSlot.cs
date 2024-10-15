// Decompiled with JetBrains decompiler
// Type: SRPG.GenericSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20024D5")]
  [AddComponentMenu("UI/GenericSlot")]
  public class GenericSlot : MonoBehaviour
  {
    [Token(Token = "0x400A832")]
    [FieldOffset(Offset = "0xC")]
    public GenericSlot.SelectEvent OnSelect;
    [Token(Token = "0x400A833")]
    [FieldOffset(Offset = "0x10")]
    [Space(10f)]
    public Graphic MainGraphic;
    [Token(Token = "0x400A834")]
    [FieldOffset(Offset = "0x14")]
    public Image BGImage;
    [Token(Token = "0x400A835")]
    [FieldOffset(Offset = "0x18")]
    public Sprite EmptyBG;
    [Token(Token = "0x400A836")]
    [FieldOffset(Offset = "0x1C")]
    public Sprite NonEmptyBG;
    [Token(Token = "0x400A837")]
    [FieldOffset(Offset = "0x20")]
    [Space(10f)]
    public SRPG_Button SelectButton;

    [Token(Token = "0x600A19D")]
    [Address(RVA = "0x638C10", Offset = "0x637A10", VA = "0x10638C10")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A19E")]
    [Address(RVA = "0x638CC0", Offset = "0x637AC0", VA = "0x10638CC0")]
    private void OnButtonClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600A19F")]
    [Address(RVA = "0x638EB0", Offset = "0x637CB0", VA = "0x10638EB0")]
    public void SetMainColor(Color color)
    {
    }

    [Token(Token = "0x600A1A0")]
    [Address(RVA = "0x638D10", Offset = "0x637B10", VA = "0x10638D10")]
    public void SetLocked(bool locked, bool is_lock_btn_set = false)
    {
    }

    [Token(Token = "0x600A1A1")]
    public void SetSlotData<T>(T data)
    {
    }

    [Token(Token = "0x600A1A2")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GenericSlot()
    {
    }

    [Token(Token = "0x20024D6")]
    public delegate void SelectEvent(GenericSlot slot, bool interactable);
  }
}
