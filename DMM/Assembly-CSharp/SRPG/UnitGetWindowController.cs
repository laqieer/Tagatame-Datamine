// Decompiled with JetBrains decompiler
// Type: SRPG.UnitGetWindowController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C30")]
  public class UnitGetWindowController : MonoBehaviour
  {
    [Token(Token = "0x400DACC")]
    [FieldOffset(Offset = "0xC")]
    private UnitGetWindow mController;
    [Token(Token = "0x400DACD")]
    [FieldOffset(Offset = "0x10")]
    private bool mIsEnd;

    [Token(Token = "0x17001B16")]
    public bool IsEnd
    {
      [Token(Token = "0x600CCAB"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600CCAC")]
    [Address(RVA = "0x9775F0", Offset = "0x9763F0", VA = "0x109775F0")]
    public void Init(UnitGetParam rewards = null)
    {
    }

    [Token(Token = "0x600CCAD")]
    [Address(RVA = "0x9779D0", Offset = "0x9767D0", VA = "0x109779D0")]
    private IEnumerator SpawnEffectAsync(string[] unitIds, bool[] isConvert, int[] covertPieces)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600CCAE")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitGetWindowController()
    {
    }
  }
}
