// Decompiled with JetBrains decompiler
// Type: SRPG.EnhanceEquipIconNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002352")]
  public class EnhanceEquipIconNode : ContentNode
  {
    [Token(Token = "0x4009E47")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public GameObject Icon;
    [Token(Token = "0x4009E48")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public GameObject EmptyObject;

    [Token(Token = "0x6009844")]
    [Address(RVA = "0x5AFB90", Offset = "0x5AE990", VA = "0x105AFB90")]
    public void Setup(EnhanceMaterial material)
    {
    }

    [Token(Token = "0x6009845")]
    [Address(RVA = "0x5AFAC0", Offset = "0x5AE8C0", VA = "0x105AFAC0")]
    public void Empty(bool is_enmpty)
    {
    }

    [Token(Token = "0x6009846")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public EnhanceEquipIconNode()
    {
    }
  }
}
