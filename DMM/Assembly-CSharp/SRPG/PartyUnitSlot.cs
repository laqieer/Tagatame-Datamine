// Decompiled with JetBrains decompiler
// Type: SRPG.PartyUnitSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027CA")]
  [AddComponentMenu("UI/PartyUnitSlot")]
  public class PartyUnitSlot : MonoBehaviour
  {
    [Token(Token = "0x400BC83")]
    [FieldOffset(Offset = "0x0")]
    public static PartyUnitSlot Active;
    [Token(Token = "0x400BC84")]
    [FieldOffset(Offset = "0xC")]
    [HelpBox("パーティ編成画面のユニットを割り当てるスロット。 選択状態あわせて StateAnimator に指定された Animator の bool 値を切り替えます。イベントにSelect()を登録してください。")]
    public Animator StateAnimator;
    [Token(Token = "0x400BC85")]
    [FieldOffset(Offset = "0x10")]
    public string AnimatorBoolName;
    [Token(Token = "0x400BC86")]
    [FieldOffset(Offset = "0x14")]
    public GameObject[] HideIfEmpty;
    [Token(Token = "0x400BC87")]
    [FieldOffset(Offset = "0x18")]
    public int Index;
    [Token(Token = "0x400BC88")]
    [FieldOffset(Offset = "0x1C")]
    public bool ToggleButtonIfEmpty;
    [Token(Token = "0x400BC89")]
    [FieldOffset(Offset = "0x20")]
    private Button mButton;

    [Token(Token = "0x600B2D5")]
    [Address(RVA = "0x7AE940", Offset = "0x7AD740", VA = "0x107AE940")]
    private void ToggleButton()
    {
    }

    [Token(Token = "0x600B2D6")]
    [Address(RVA = "0x7AE900", Offset = "0x7AD700", VA = "0x107AE900")]
    public void Select()
    {
    }

    [Token(Token = "0x600B2D7")]
    [Address(RVA = "0x7AE890", Offset = "0x7AD690", VA = "0x107AE890")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B2D8")]
    [Address(RVA = "0x7AE9E0", Offset = "0x7AD7E0", VA = "0x107AE9E0")]
    public void Update()
    {
    }

    [Token(Token = "0x600B2D9")]
    [Address(RVA = "0x7AEB60", Offset = "0x7AD960", VA = "0x107AEB60")]
    public PartyUnitSlot()
    {
    }
  }
}
