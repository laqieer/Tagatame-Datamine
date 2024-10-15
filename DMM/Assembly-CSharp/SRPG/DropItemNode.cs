// Decompiled with JetBrains decompiler
// Type: SRPG.DropItemNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002304")]
  [AddComponentMenu("UI/DropItemNode")]
  public class DropItemNode : ContentNode
  {
    [Token(Token = "0x4009C51")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private DropItemIcon mDropItemIcon;

    [Token(Token = "0x17001505")]
    public DropItemIcon DropItemIcon
    {
      [Token(Token = "0x60096BC"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (DropItemIcon) null;
      }
    }

    [Token(Token = "0x60096BD")]
    [Address(RVA = "0x596DC0", Offset = "0x595BC0", VA = "0x10596DC0", Slot = "4")]
    public override void Initialize(ContentController controller)
    {
    }

    [Token(Token = "0x60096BE")]
    [Address(RVA = "0x596DD0", Offset = "0x595BD0", VA = "0x10596DD0", Slot = "5")]
    public override void Release()
    {
    }

    [Token(Token = "0x60096BF")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public DropItemNode()
    {
    }
  }
}
