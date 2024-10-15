// Decompiled with JetBrains decompiler
// Type: SRPG.ArenaRewardList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FDD")]
  [AddComponentMenu("UI/ArenaRewardList")]
  public class ArenaRewardList : SRPG_ListBase
  {
    [Token(Token = "0x4008718")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ArenaRewardListItem ListItem;

    [Token(Token = "0x6008337")]
    [Address(RVA = "0x43B000", Offset = "0x439E00", VA = "0x1043B000", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x6008338")]
    [Address(RVA = "0x43AD50", Offset = "0x439B50", VA = "0x1043AD50")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008339")]
    [Address(RVA = "0x438D60", Offset = "0x437B60", VA = "0x10438D60")]
    public ArenaRewardList()
    {
    }
  }
}
