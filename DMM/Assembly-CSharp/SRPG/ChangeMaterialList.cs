// Decompiled with JetBrains decompiler
// Type: SRPG.ChangeMaterialList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002139")]
  [AddComponentMenu("UI/ChangeMaterialList")]
  public class ChangeMaterialList : MonoBehaviour
  {
    [Token(Token = "0x40090A5")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Material mMat;
    [Token(Token = "0x40090A6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Image[] ChangeList;

    [Token(Token = "0x6008B6C")]
    [Address(RVA = "0x4F5510", Offset = "0x4F4310", VA = "0x104F5510")]
    private void Start()
    {
    }

    [Token(Token = "0x6008B6D")]
    [Address(RVA = "0x4F5450", Offset = "0x4F4250", VA = "0x104F5450")]
    public void SetMaterial(Material mat)
    {
    }

    [Token(Token = "0x6008B6E")]
    [Address(RVA = "0x4F5350", Offset = "0x4F4150", VA = "0x104F5350")]
    public void SetColor(Color color)
    {
    }

    [Token(Token = "0x6008B6F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ChangeMaterialList()
    {
    }
  }
}
