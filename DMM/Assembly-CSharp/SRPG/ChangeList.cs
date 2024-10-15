// Decompiled with JetBrains decompiler
// Type: SRPG.ChangeList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002136")]
  [AddComponentMenu("UI/ChangeList")]
  public class ChangeList : MonoBehaviour
  {
    [Token(Token = "0x4009098")]
    [FieldOffset(Offset = "0xC")]
    public GameObject List;
    [Token(Token = "0x4009099")]
    [FieldOffset(Offset = "0x10")]
    [FlexibleArray]
    public ChangeListItem[] ListItems;

    [Token(Token = "0x6008B66")]
    [Address(RVA = "0x4F4DA0", Offset = "0x4F3BA0", VA = "0x104F4DA0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008B67")]
    [Address(RVA = "0x4F51F0", Offset = "0x4F3FF0", VA = "0x104F51F0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008B68")]
    [Address(RVA = "0x4F4E10", Offset = "0x4F3C10", VA = "0x104F4E10")]
    public void SetData(ChangeListData[] src)
    {
    }

    [Token(Token = "0x6008B69")]
    [Address(RVA = "0x4F5300", Offset = "0x4F4100", VA = "0x104F5300")]
    public ChangeList()
    {
    }
  }
}
