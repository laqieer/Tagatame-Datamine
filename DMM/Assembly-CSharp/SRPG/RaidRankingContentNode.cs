// Decompiled with JetBrains decompiler
// Type: SRPG.RaidRankingContentNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028EA")]
  public class RaidRankingContentNode : ContentNode
  {
    [Token(Token = "0x400C4BD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject GuildNonObj;

    [Token(Token = "0x600B92F")]
    [Address(RVA = "0x805940", Offset = "0x804740", VA = "0x10805940")]
    public void Setup(RaidRankingData data)
    {
    }

    [Token(Token = "0x600B930")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public RaidRankingContentNode()
    {
    }
  }
}
