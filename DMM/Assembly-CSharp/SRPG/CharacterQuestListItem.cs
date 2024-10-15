// Decompiled with JetBrains decompiler
// Type: SRPG.CharacterQuestListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002149")]
  [AddComponentMenu("UI/CharacterQuestListItem")]
  public class CharacterQuestListItem : MonoBehaviour
  {
    [Token(Token = "0x40090F3")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject unitIcon1;
    [Token(Token = "0x40090F4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject unitIcon2;
    [Token(Token = "0x40090F5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text conditionText;

    [Token(Token = "0x6008BB7")]
    [Address(RVA = "0x4F7570", Offset = "0x4F6370", VA = "0x104F7570")]
    public void SetUp(UnitData unitData1, UnitData unitData2, QuestParam questParam)
    {
    }

    [Token(Token = "0x6008BB8")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CharacterQuestListItem()
    {
    }
  }
}
