// Decompiled with JetBrains decompiler
// Type: Gsc.Network.CustomHeaders
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine.Networking;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x2003561")]
  public class CustomHeaders
  {
    [Token(Token = "0x400FCDF")]
    [FieldOffset(Offset = "0x8")]
    private readonly string requestId;
    [Token(Token = "0x400FCE0")]
    [FieldOffset(Offset = "0xC")]
    private readonly Dictionary<string, string> headers;
    [Token(Token = "0x400FCE1")]
    [FieldOffset(Offset = "0x10")]
    private readonly List<Dictionary<string, string>> headersList;

    [Token(Token = "0x170021DB")]
    public bool IsUseEncryption
    {
      [Token(Token = "0x600EC8A"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600EC8B"), Address(RVA = "0x357B00", Offset = "0x356900", VA = "0x10357B00")] set
      {
      }
    }

    [Token(Token = "0x600EC8C")]
    [Address(RVA = "0xB033A0", Offset = "0xB021A0", VA = "0x10B033A0")]
    public CustomHeaders(string requestId)
    {
    }

    [Token(Token = "0x600EC8D")]
    [Address(RVA = "0xB02770", Offset = "0xB01570", VA = "0x10B02770")]
    public void SetCustomHeader(string key, string value, Action<string, string> setter = null)
    {
    }

    [Token(Token = "0x600EC8E")]
    [Address(RVA = "0xB021B0", Offset = "0xB00FB0", VA = "0x10B021B0")]
    public void AddCustomHeaders(Dictionary<string, string> headers)
    {
    }

    [Token(Token = "0x600EC8F")]
    [Address(RVA = "0xB02830", Offset = "0xB01630", VA = "0x10B02830")]
    public void SetSerializationCompressionEncryptionHeaders(
      string url,
      EncodingTypes.ESerializeCompressMethod method,
      Action<string, string> setter = null)
    {
    }

    [Token(Token = "0x600EC90")]
    [Address(RVA = "0xB02200", Offset = "0xB01000", VA = "0x10B02200")]
    public void Dispatch(UnityWebRequest request)
    {
    }

    [Token(Token = "0x600EC91")]
    [Address(RVA = "0xB025A0", Offset = "0xB013A0", VA = "0x10B025A0")]
    private void Dispatch(Action<string, string> setter, Dictionary<string, string> headers)
    {
    }

    [Token(Token = "0x600EC92")]
    [Address(RVA = "0xB03350", Offset = "0xB02150", VA = "0x10B03350")]
    public static void SetXGumiDeviceStorePlatform(Action<string, string> setter)
    {
    }
  }
}
