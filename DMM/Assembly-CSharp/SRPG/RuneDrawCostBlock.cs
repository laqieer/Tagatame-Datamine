// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDrawCostBlock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002982")]
  public class RuneDrawCostBlock : MonoBehaviour
  {
    [Token(Token = "0x400C86E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400C86F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Color32 mDefaultColor;
    [Token(Token = "0x400C870")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Color32 mMinusColor;
    [Token(Token = "0x400C871")]
    [FieldOffset(Offset = "0x18")]
    private RuneDrawCostBlockModel mModel;

    [Token(Token = "0x17001981")]
    public RuneDrawCostBlockModel Model
    {
      [Token(Token = "0x600BC12"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (RuneDrawCostBlockModel) null;
      }
    }

    [Token(Token = "0x600BC13")]
    [Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x1083B710")]
    public void Initialize(string image_path, int value, int have_value)
    {
    }

    [Token(Token = "0x600BC14")]
    [Address(RVA = "0x83B7E0", Offset = "0x83A5E0", VA = "0x1083B7E0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BC15")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneDrawCostBlock()
    {
    }
  }
}
