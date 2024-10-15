// Decompiled with JetBrains decompiler
// Type: SRPG.GachaElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002429")]
  [AddComponentMenu("UI/GachaElement")]
  public class GachaElement : MonoBehaviour
  {
    [Token(Token = "0x400A3CD")]
    [FieldOffset(Offset = "0xC")]
    public GachaTypes GachaType;
    [Token(Token = "0x400A3CE")]
    [FieldOffset(Offset = "0x10")]
    public GameObject GachaButtonParent;
    [Token(Token = "0x400A3CF")]
    [FieldOffset(Offset = "0x14")]
    public GameObject FreeGacha;
    [Token(Token = "0x400A3D0")]
    [FieldOffset(Offset = "0x18")]
    public GameObject SingularGacha;
    [Token(Token = "0x400A3D1")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject MultipleGacha;
    [Token(Token = "0x400A3D2")]
    [FieldOffset(Offset = "0x20")]
    public Button BtnFreeGacha;
    [Token(Token = "0x400A3D3")]
    [FieldOffset(Offset = "0x24")]
    public Button BtnSingularGacha;
    [Token(Token = "0x400A3D4")]
    [FieldOffset(Offset = "0x28")]
    public Button BtnMultipleGacha;

    [Token(Token = "0x6009DB9")]
    [Address(RVA = "0x601410", Offset = "0x600210", VA = "0x10601410")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009DBA")]
    [Address(RVA = "0x601480", Offset = "0x600280", VA = "0x10601480")]
    public void Reflesh()
    {
    }

    [Token(Token = "0x6009DBB")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GachaElement()
    {
    }
  }
}
