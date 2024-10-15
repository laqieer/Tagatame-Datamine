// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideReturnItemListView
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
  [Token(Token = "0x2002A50")]
  public class RunePrideReturnItemListView : MonoBehaviour
  {
    [Token(Token = "0x400CDF5")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x400CDF6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform ParentObj;
    [Token(Token = "0x400CDF7")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ContentExhibit ContentList;
    [Token(Token = "0x400CDF8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RunePrideReturnItemListView.ListType DispType;
    [Token(Token = "0x400CDF9")]
    [FieldOffset(Offset = "0x1C")]
    protected List<RunePrideReturnItemModel> mModelList;
    [Token(Token = "0x400CDFA")]
    [FieldOffset(Offset = "0x20")]
    private List<GameObject> mItemList;

    [Token(Token = "0x600C117")]
    [Address(RVA = "0x898C10", Offset = "0x897A10", VA = "0x10898C10")]
    public void Init(JSON_RunePrideItemData[] _item_list)
    {
    }

    [Token(Token = "0x600C118")]
    [Address(RVA = "0x898950", Offset = "0x897750", VA = "0x10898950")]
    public void Init(JSON_RunePrideUsedItemData[] _item_list)
    {
    }

    [Token(Token = "0x600C119")]
    [Address(RVA = "0x8984D0", Offset = "0x8972D0", VA = "0x108984D0")]
    protected void CreateList()
    {
    }

    [Token(Token = "0x600C11A")]
    [Address(RVA = "0x898EC0", Offset = "0x897CC0", VA = "0x10898EC0")]
    public RunePrideReturnItemListView()
    {
    }

    [Token(Token = "0x2002A51")]
    public enum ListType
    {
      [Token(Token = "0x400CDFC")] ItemList,
      [Token(Token = "0x400CDFD")] ContentNode,
    }
  }
}
