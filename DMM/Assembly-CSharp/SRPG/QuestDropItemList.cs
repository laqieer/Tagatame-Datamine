// Decompiled with JetBrains decompiler
// Type: SRPG.QuestDropItemList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002897")]
  [AddComponentMenu("UI/QuestDropItemList")]
  public class QuestDropItemList : MonoBehaviour
  {
    [Token(Token = "0x400C245")]
    [FieldOffset(Offset = "0xC")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400C246")]
    [FieldOffset(Offset = "0x10")]
    protected List<GameObject> mItems;

    [Token(Token = "0x600B77C")]
    [Address(RVA = "0x7E3990", Offset = "0x7E2790", VA = "0x107E3990")]
    private void Start()
    {
    }

    [Token(Token = "0x600B77D")]
    [Address(RVA = "0x7E36A0", Offset = "0x7E24A0", VA = "0x107E36A0", Slot = "4")]
    protected virtual void Refresh()
    {
    }

    [Token(Token = "0x600B77E")]
    [Address(RVA = "0x7E3A30", Offset = "0x7E2830", VA = "0x107E3A30")]
    public QuestDropItemList()
    {
    }
  }
}
