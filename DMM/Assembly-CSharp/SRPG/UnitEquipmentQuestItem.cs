// Decompiled with JetBrains decompiler
// Type: SRPG.UnitEquipmentQuestItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C0E")]
  [AddComponentMenu("UI/UnitEquipmentQuestItem")]
  public class UnitEquipmentQuestItem : MonoBehaviour
  {
    [Token(Token = "0x400D9B8")]
    [FieldOffset(Offset = "0xC")]
    public GameObject QuestButton;
    [Token(Token = "0x400D9B9")]
    [FieldOffset(Offset = "0x10")]
    public GameObject QuestLockButton;
    [Token(Token = "0x400D9BA")]
    [FieldOffset(Offset = "0x14")]
    public GameObject QuestDetail;
    [Token(Token = "0x400D9BB")]
    [FieldOffset(Offset = "0x18")]
    public GameObject QuestDetailMask;
    [Token(Token = "0x400D9BC")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject QuestDisabled;

    [Token(Token = "0x600CBD9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitEquipmentQuestItem()
    {
    }
  }
}
