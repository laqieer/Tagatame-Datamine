// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestResultSubListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002838")]
  public class PointQuestResultSubListItem : MonoBehaviour
  {
    [Token(Token = "0x400BFD2")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [HeaderBar("▼小項目用")]
    private PointQuestResultSubItem SubObj;
    [Token(Token = "0x400BFD3")]
    [FieldOffset(Offset = "0x10")]
    private List<PointQuestResultSubItem> mListItem;
    [Token(Token = "0x400BFD4")]
    [FieldOffset(Offset = "0x14")]
    private bool mIsListItemActive;

    [Token(Token = "0x600B587")]
    [Address(RVA = "0x7BEFE0", Offset = "0x7BDDE0", VA = "0x107BEFE0")]
    public void SetUpSubItem(string _title_key, int _value, string _unit_key)
    {
    }

    [Token(Token = "0x600B588")]
    [Address(RVA = "0x7BEF60", Offset = "0x7BDD60", VA = "0x107BEF60")]
    public void ActiveListItem()
    {
    }

    [Token(Token = "0x600B589")]
    [Address(RVA = "0x7BEEF0", Offset = "0x7BDCF0", VA = "0x107BEEF0")]
    private IEnumerator ActiveItem() => (IEnumerator) null;

    [Token(Token = "0x600B58A")]
    [Address(RVA = "0x7BF0F0", Offset = "0x7BDEF0", VA = "0x107BF0F0")]
    public PointQuestResultSubListItem()
    {
    }
  }
}
