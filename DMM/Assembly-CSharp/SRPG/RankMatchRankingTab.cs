// Decompiled with JetBrains decompiler
// Type: SRPG.RankMatchRankingTab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002926")]
  [AddComponentMenu("UI/RankMatchRankingTab")]
  public class RankMatchRankingTab : SRPG_ListBase
  {
    [Token(Token = "0x400C614")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject PlayerGO;
    [Token(Token = "0x400C615")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject PlayerUnit;
    [Token(Token = "0x400C616")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ListItemEvents ListItem;

    [Token(Token = "0x600BA25")]
    [Address(RVA = "0x8177B0", Offset = "0x8165B0", VA = "0x108177B0", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600BA26")]
    [Address(RVA = "0x8172E0", Offset = "0x8160E0", VA = "0x108172E0")]
    private void ResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x600BA27")]
    [Address(RVA = "0x817260", Offset = "0x816060", VA = "0x10817260")]
    private void RequestError()
    {
    }

    [Token(Token = "0x600BA28")]
    [Address(RVA = "0x438D60", Offset = "0x437B60", VA = "0x10438D60")]
    public RankMatchRankingTab()
    {
    }
  }
}
