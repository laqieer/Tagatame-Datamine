// Decompiled with JetBrains decompiler
// Type: SRPG.PlayerInfoWindow
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
  [Token(Token = "0x20027F7")]
  public class PlayerInfoWindow : MonoBehaviour
  {
    [Token(Token = "0x400BE3A")]
    [FieldOffset(Offset = "0xC")]
    private PlayerInfoModel mModel;
    [Token(Token = "0x400BE3B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList mExhibit;

    [Token(Token = "0x600B476")]
    [Address(RVA = "0x7B0010", Offset = "0x7AEE10", VA = "0x107B0010")]
    private void Start()
    {
    }

    [Token(Token = "0x600B477")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public PlayerInfoWindow()
    {
    }
  }
}
