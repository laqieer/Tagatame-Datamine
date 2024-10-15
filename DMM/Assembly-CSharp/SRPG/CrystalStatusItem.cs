// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalStatusItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200229E")]
  public class CrystalStatusItem : MonoBehaviour
  {
    [Token(Token = "0x40099C1")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x40099C2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text ValueText;
    [Token(Token = "0x40099C3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text LimitText;
    [Token(Token = "0x40099C4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Color ValueOverColor;
    [Token(Token = "0x40099C5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Color LimitAddColor;
    [Token(Token = "0x40099C6")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Color LimitDecreaseColor;
    [Token(Token = "0x40099C7")]
    [FieldOffset(Offset = "0x48")]
    private CrystalStatusItemModel mModel;

    [Token(Token = "0x600943E")]
    [Address(RVA = "0x572C80", Offset = "0x571A80", VA = "0x10572C80")]
    public void SetUp(ParamTypes _type, int _value, string _tag, int _limit, bool _is_limit_add)
    {
    }

    [Token(Token = "0x600943F")]
    [Address(RVA = "0x572BA0", Offset = "0x5719A0", VA = "0x10572BA0")]
    public void DestroyItem()
    {
    }

    [Token(Token = "0x6009440")]
    [Address(RVA = "0x572C00", Offset = "0x571A00", VA = "0x10572C00")]
    public void Draw()
    {
    }

    [Token(Token = "0x6009441")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalStatusItem()
    {
    }
  }
}
