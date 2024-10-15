// Decompiled with JetBrains decompiler
// Type: SRPG.VersusPlayerInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002752")]
  [AddComponentMenu("UI/Multi/Versus/VersusPlayerInfo")]
  public class VersusPlayerInfo : MonoBehaviour
  {
    [Token(Token = "0x400B99E")]
    [FieldOffset(Offset = "0xC")]
    public GameObject template;
    [Token(Token = "0x400B99F")]
    [FieldOffset(Offset = "0x10")]
    public GameObject parent;

    [Token(Token = "0x600B073")]
    [Address(RVA = "0x750C60", Offset = "0x74FA60", VA = "0x10750C60")]
    private void Start()
    {
    }

    [Token(Token = "0x600B074")]
    [Address(RVA = "0x750AE0", Offset = "0x74F8E0", VA = "0x10750AE0")]
    private void RefreshData()
    {
    }

    [Token(Token = "0x600B075")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public VersusPlayerInfo()
    {
    }
  }
}
