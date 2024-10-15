// Decompiled with JetBrains decompiler
// Type: SRPG.UnitEquipmentSlotEvents
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C0F")]
  [RequireComponent(typeof (Animator))]
  public class UnitEquipmentSlotEvents : ListItemEvents
  {
    [Token(Token = "0x400D9BD")]
    [FieldOffset(Offset = "0x38")]
    [HelpBox("スロットの状態にあわせてこの数値を切り替えます。スロットが空=0、装備は持ってる=1、レベル足りない=2、装備してる=3")]
    public string StateIntName;

    [Token(Token = "0x17001B06")]
    public UnitEquipmentSlotEvents.SlotStateTypes StateType
    {
      [Token(Token = "0x600CBDA"), Address(RVA = "0x96A800", Offset = "0x969600", VA = "0x1096A800")] set
      {
      }
    }

    [Token(Token = "0x600CBDB")]
    [Address(RVA = "0x96A7B0", Offset = "0x9695B0", VA = "0x1096A7B0")]
    public UnitEquipmentSlotEvents()
    {
    }

    [Token(Token = "0x2002C10")]
    public enum SlotStateTypes
    {
      [Token(Token = "0x400D9BF")] Empty,
      [Token(Token = "0x400D9C0")] HasEquipment,
      [Token(Token = "0x400D9C1")] NeedMoreLevel,
      [Token(Token = "0x400D9C2")] Equipped,
      [Token(Token = "0x400D9C3")] EnableCraft,
      [Token(Token = "0x400D9C4")] EnableCraftNeedMoreLevel,
      [Token(Token = "0x400D9C5")] None,
      [Token(Token = "0x400D9C6")] EnableCommon,
      [Token(Token = "0x400D9C7")] EnableCommonSoul,
      [Token(Token = "0x400D9C8")] EnableCommonSoulNeedMoreLevel,
    }
  }
}
