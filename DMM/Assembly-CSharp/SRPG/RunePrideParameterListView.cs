// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideParameterListView
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
  [Token(Token = "0x2002A2F")]
  public class RunePrideParameterListView : MonoBehaviour
  {
    [Token(Token = "0x400CCE7")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x400CCE8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform ParentObj;
    [Token(Token = "0x400CCE9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ContentExhibit ContentList;
    [Token(Token = "0x400CCEA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RunePrideParameterListView.ListType DispType;
    [Token(Token = "0x400CCEB")]
    [FieldOffset(Offset = "0x1C")]
    private List<BaseParameterModel> mModelList;
    [Token(Token = "0x400CCEC")]
    [FieldOffset(Offset = "0x20")]
    private List<GameObject> mItemList;

    [Token(Token = "0x600C047")]
    [Address(RVA = "0x88B320", Offset = "0x88A120", VA = "0x1088B320")]
    private void Start()
    {
    }

    [Token(Token = "0x600C048")]
    [Address(RVA = "0x88AB40", Offset = "0x889940", VA = "0x1088AB40")]
    private void CreateList()
    {
    }

    [Token(Token = "0x600C049")]
    [Address(RVA = "0x88A700", Offset = "0x889500", VA = "0x1088A700")]
    private void ChangeList()
    {
    }

    [Token(Token = "0x600C04A")]
    [Address(RVA = "0x88AFB0", Offset = "0x889DB0", VA = "0x1088AFB0")]
    public void Init(List<BaseParameterData> _data_list)
    {
    }

    [Token(Token = "0x600C04B")]
    [Address(RVA = "0x88A370", Offset = "0x889170", VA = "0x1088A370")]
    public void AddParameter(List<BaseParameterData> _data_list)
    {
    }

    [Token(Token = "0x600C04C")]
    [Address(RVA = "0x88B370", Offset = "0x88A170", VA = "0x1088B370")]
    public void SubParameter(List<BaseParameterData> _data_list)
    {
    }

    [Token(Token = "0x600C04D")]
    [Address(RVA = "0x88B220", Offset = "0x88A020", VA = "0x1088B220")]
    private void ModelSort()
    {
    }

    [Token(Token = "0x600C04E")]
    [Address(RVA = "0x88B660", Offset = "0x88A460", VA = "0x1088B660")]
    public RunePrideParameterListView()
    {
    }

    [Token(Token = "0x2002A30")]
    public enum ListType
    {
      [Token(Token = "0x400CCEE")] ItemList,
      [Token(Token = "0x400CCEF")] ContentNode,
    }
  }
}
