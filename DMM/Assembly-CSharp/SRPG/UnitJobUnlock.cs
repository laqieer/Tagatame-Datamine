// Decompiled with JetBrains decompiler
// Type: SRPG.UnitJobUnlock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C5D")]
  [AddComponentMenu("UI/UnitJobUnlock")]
  public class UnitJobUnlock : MonoBehaviour
  {
    [Token(Token = "0x400DB9F")]
    [FieldOffset(Offset = "0xC")]
    public GameObject JobIcon;
    [Token(Token = "0x400DBA0")]
    [FieldOffset(Offset = "0x10")]
    public Text JobName;

    [Token(Token = "0x600CD8A")]
    [Address(RVA = "0x982C20", Offset = "0x981A20", VA = "0x10982C20")]
    private void Start()
    {
    }

    [Token(Token = "0x600CD8B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitJobUnlock()
    {
    }
  }
}
