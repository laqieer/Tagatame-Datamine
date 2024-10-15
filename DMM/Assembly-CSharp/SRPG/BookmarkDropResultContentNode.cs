// Decompiled with JetBrains decompiler
// Type: SRPG.BookmarkDropResultContentNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020D9")]
  public class BookmarkDropResultContentNode : ContentNode
  {
    [Token(Token = "0x4008DCF")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RewardIcon mRewardIcon;

    [Token(Token = "0x60088FD")]
    [Address(RVA = "0x4A3860", Offset = "0x4A2660", VA = "0x104A3860")]
    public bool Setup(string iname, int num) => new bool();

    [Token(Token = "0x60088FE")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public BookmarkDropResultContentNode()
    {
    }
  }
}
