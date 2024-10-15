// Decompiled with JetBrains decompiler
// Type: SRPG.RuneSortCategory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AE6")]
  [AddComponentMenu("UI/SortFilter/RuneSortCategory")]
  public class RuneSortCategory : MonoBehaviour
  {
    [Token(Token = "0x400D14B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mHeaderText;
    [Token(Token = "0x400D14C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RuneSortToggleItem mToggleTemplate;
    [Token(Token = "0x400D14D")]
    [FieldOffset(Offset = "0x14")]
    private SortRuneParam mSortParam;
    [Token(Token = "0x400D14E")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<string, RuneSortToggleItem> mCreatedToggles;

    [Token(Token = "0x17001A1B")]
    public SortRuneParam SortParam
    {
      [Token(Token = "0x600C404"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (SortRuneParam) null;
      }
    }

    [Token(Token = "0x17001A1C")]
    public RuneSortToggleItem[] ToggleValues
    {
      [Token(Token = "0x600C405"), Address(RVA = "0x8C4A10", Offset = "0x8C3810", VA = "0x108C4A10")] get
      {
        return (RuneSortToggleItem[]) null;
      }
    }

    [Token(Token = "0x600C406")]
    [Address(RVA = "0x8C4440", Offset = "0x8C3240", VA = "0x108C4440")]
    public void Init(SortRuneParam sort_param)
    {
    }

    [Token(Token = "0x600C407")]
    [Address(RVA = "0x8C48F0", Offset = "0x8C36F0", VA = "0x108C48F0")]
    private void OnToggleValueChanged()
    {
    }

    [Token(Token = "0x600C408")]
    [Address(RVA = "0x8C4760", Offset = "0x8C3560", VA = "0x108C4760")]
    public bool IsExistActiveToggle() => new bool();

    [Token(Token = "0x600C409")]
    [Address(RVA = "0x8C49A0", Offset = "0x8C37A0", VA = "0x108C49A0")]
    public RuneSortCategory()
    {
    }
  }
}
