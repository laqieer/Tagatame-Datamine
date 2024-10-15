// Decompiled with JetBrains decompiler
// Type: SRPG.BaseNeedItemListView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029F7")]
  public class BaseNeedItemListView : MonoBehaviour
  {
    [Token(Token = "0x400CBE6")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    protected GameObject ItemTemplate;
    [Token(Token = "0x400CBE7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform ParentObj;
    [Token(Token = "0x400CBE8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ContentExhibit ContentList;
    [Token(Token = "0x400CBE9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BaseNeedItemListView.ListType DispType;
    [Token(Token = "0x400CBEA")]
    [FieldOffset(Offset = "0x1C")]
    protected List<NeedItemModel> mModelList;
    [Token(Token = "0x400CBEB")]
    [FieldOffset(Offset = "0x20")]
    private List<GameObject> mItemList;

    [Token(Token = "0x600BF4B")]
    [Address(RVA = "0x855AB0", Offset = "0x8548B0", VA = "0x10855AB0")]
    protected void CreateList()
    {
    }

    [Token(Token = "0x600BF4C")]
    [Address(RVA = "0x8554A0", Offset = "0x8542A0", VA = "0x108554A0")]
    protected void ChangeList()
    {
    }

    [Token(Token = "0x600BF4D")]
    [Address(RVA = "0x855F10", Offset = "0x854D10", VA = "0x10855F10")]
    public BaseNeedItemListView()
    {
    }

    [Token(Token = "0x20029F8")]
    public enum ListType
    {
      [Token(Token = "0x400CBED")] ItemList,
      [Token(Token = "0x400CBEE")] ContentNode,
    }
  }
}
