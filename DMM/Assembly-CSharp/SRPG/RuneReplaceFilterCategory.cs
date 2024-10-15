// Decompiled with JetBrains decompiler
// Type: SRPG.RuneReplaceFilterCategory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029C4")]
  public class RuneReplaceFilterCategory : MonoBehaviour
  {
    [Token(Token = "0x400CA95")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RuneReplaceFilterWindow mWindow;
    [Token(Token = "0x400CA96")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400CA97")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RuneFilterToggle mToggleTemplate;
    [Token(Token = "0x400CA98")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<string, Toggle> mToggleDic;
    [Token(Token = "0x400CA99")]
    [FieldOffset(Offset = "0x1C")]
    private RuneReplaceFilterCategoryModel mModel;

    [Token(Token = "0x170019A7")]
    public Dictionary<string, Toggle> ToggleDic
    {
      [Token(Token = "0x600BE03"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (Dictionary<string, Toggle>) null;
      }
    }

    [Token(Token = "0x600BE04")]
    [Address(RVA = "0x8587C0", Offset = "0x8575C0", VA = "0x108587C0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600BE05")]
    [Address(RVA = "0x8587E0", Offset = "0x8575E0", VA = "0x108587E0")]
    public void Initialize(RuneReplaceFilterCategoryModel model)
    {
    }

    [Token(Token = "0x600BE06")]
    [Address(RVA = "0x858430", Offset = "0x857230", VA = "0x10858430")]
    private void InitializeToggles()
    {
    }

    [Token(Token = "0x600BE07")]
    [Address(RVA = "0x858B00", Offset = "0x857900", VA = "0x10858B00")]
    private void Setup()
    {
    }

    [Token(Token = "0x600BE08")]
    [Address(RVA = "0x858AB0", Offset = "0x8578B0", VA = "0x10858AB0")]
    private void OnToggleValueChanged()
    {
    }

    [Token(Token = "0x600BE09")]
    [Address(RVA = "0x858930", Offset = "0x857730", VA = "0x10858930")]
    public bool IsExistActiveToggle() => new bool();

    [Token(Token = "0x600BE0A")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneReplaceFilterCategory()
    {
    }
  }
}
