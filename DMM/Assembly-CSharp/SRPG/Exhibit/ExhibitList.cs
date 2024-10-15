// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.ExhibitList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003434")]
  public class ExhibitList : MonoBehaviour
  {
    [Token(Token = "0x400F79E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    public MonoBehaviour[] m_Exhibits;

    [Token(Token = "0x600E93F")]
    [Address(RVA = "0xADC470", Offset = "0xADB270", VA = "0x10ADC470")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E940")]
    [Address(RVA = "0xADC4F0", Offset = "0xADB2F0", VA = "0x10ADC4F0")]
    public void Release()
    {
    }

    [Token(Token = "0x600E941")]
    public void Render<T>(T model) where T : class
    {
    }

    [Token(Token = "0x600E942")]
    [Address(RVA = "0xADC570", Offset = "0xADB370", VA = "0x10ADC570")]
    public ExhibitList()
    {
    }
  }
}
