// Decompiled with JetBrains decompiler
// Type: SRPG.RankMatchClassList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002912")]
  [AddComponentMenu("UI/RankMatchClassList")]
  public class RankMatchClassList : SRPG_ListBase
  {
    [Token(Token = "0x400C5E2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RankMatchClassListItem ListItem;

    [Token(Token = "0x600B9F0")]
    [Address(RVA = "0x80EB50", Offset = "0x80D950", VA = "0x1080EB50", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600B9F1")]
    [Address(RVA = "0x438D60", Offset = "0x437B60", VA = "0x10438D60")]
    public RankMatchClassList()
    {
    }
  }
}
