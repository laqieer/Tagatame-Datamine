// Decompiled with JetBrains decompiler
// Type: SRPG.RuneReplaceContentNode
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
  [Token(Token = "0x20029C2")]
  public class RuneReplaceContentNode : ContentNode
  {
    [Token(Token = "0x400CA8C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400CA8D")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mRuneParent;
    [Token(Token = "0x400CA8E")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private RuneSlotEx mRuneTemplate;
    [Token(Token = "0x400CA8F")]
    [FieldOffset(Offset = "0x3C")]
    private List<RuneSlotEx> mRuneIconList;
    [Token(Token = "0x400CA90")]
    [FieldOffset(Offset = "0x40")]
    private RuneReplaceContentNodeModel mModel;

    [Token(Token = "0x170019A3")]
    public RuneReplaceContentNodeModel Model
    {
      [Token(Token = "0x600BDEC"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (RuneReplaceContentNodeModel) null;
      }
    }

    [Token(Token = "0x600BDED")]
    [Address(RVA = "0x8575A0", Offset = "0x8563A0", VA = "0x108575A0", Slot = "11")]
    public override void OnEnable()
    {
    }

    [Token(Token = "0x600BDEE")]
    [Address(RVA = "0x857440", Offset = "0x856240", VA = "0x10857440")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600BDEF")]
    [Address(RVA = "0x857790", Offset = "0x856590", VA = "0x10857790")]
    public void RuneSlotSetup()
    {
    }

    [Token(Token = "0x600BDF0")]
    [Address(RVA = "0x8575D0", Offset = "0x8563D0", VA = "0x108575D0")]
    public void RuneDataSet(RuneReplaceContentParam param)
    {
    }

    [Token(Token = "0x600BDF1")]
    [Address(RVA = "0x857990", Offset = "0x856790", VA = "0x10857990")]
    public void SelectRune(RuneIcon icon)
    {
    }

    [Token(Token = "0x600BDF2")]
    [Address(RVA = "0x857CE0", Offset = "0x856AE0", VA = "0x10857CE0")]
    private void Setup()
    {
    }

    [Token(Token = "0x600BDF3")]
    [Address(RVA = "0x857BD0", Offset = "0x8569D0", VA = "0x10857BD0")]
    public void SetupRuneRender(RuneReplaceContentNodeModel model)
    {
    }

    [Token(Token = "0x600BDF4")]
    [Address(RVA = "0x857300", Offset = "0x856100", VA = "0x10857300")]
    public void EquipAnimation()
    {
    }

    [Token(Token = "0x600BDF5")]
    [Address(RVA = "0x8572E0", Offset = "0x8560E0", VA = "0x108572E0")]
    public void ClearEquipAnimationFlag()
    {
    }

    [Token(Token = "0x600BDF6")]
    [Address(RVA = "0x8574D0", Offset = "0x8562D0", VA = "0x108574D0")]
    public bool IsUnitContentNode(string unit) => new bool();

    [Token(Token = "0x600BDF7")]
    [Address(RVA = "0x857500", Offset = "0x856300", VA = "0x10857500")]
    public void OnClickRuneReplace()
    {
    }

    [Token(Token = "0x600BDF8")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public RuneReplaceContentNode()
    {
    }
  }
}
