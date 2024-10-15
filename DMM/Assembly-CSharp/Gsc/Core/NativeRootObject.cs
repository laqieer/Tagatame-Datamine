// Decompiled with JetBrains decompiler
// Type: Gsc.Core.NativeRootObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Gsc.Core
{
  [Token(Token = "0x20035E2")]
  public class NativeRootObject : MonoBehaviour
  {
    [Token(Token = "0x400FE15")]
    [FieldOffset(Offset = "0x0")]
    private static NativeRootObject _instance;

    [Token(Token = "0x1700225F")]
    public static NativeRootObject Instance
    {
      [Token(Token = "0x600F023"), Address(RVA = "0xB0CCD0", Offset = "0xB0BAD0", VA = "0x10B0CCD0")] get
      {
        return (NativeRootObject) null;
      }
    }

    [Token(Token = "0x600F024")]
    [Address(RVA = "0xB0CC90", Offset = "0xB0BA90", VA = "0x10B0CC90")]
    private void Awake()
    {
    }

    [Token(Token = "0x600F025")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public NativeRootObject()
    {
    }
  }
}
