// Decompiled with JetBrains decompiler
// Type: SRPG.DownloadLogger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.Networking;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E26")]
  public class DownloadLogger : DownloadHandlerScript
  {
    [Token(Token = "0x4002ADE")]
    [FieldOffset(Offset = "0xC")]
    private VersusAudienceManager mManager;
    [Token(Token = "0x4002ADF")]
    [FieldOffset(Offset = "0x10")]
    private string mParam;

    [Token(Token = "0x1700042A")]
    public VersusAudienceManager Manager
    {
      [Token(Token = "0x6003A3F"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] set
      {
      }
    }

    [Token(Token = "0x1700042B")]
    public string Response
    {
      [Token(Token = "0x6003A40"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6003A41")]
    [Address(RVA = "0x10DA8F0", Offset = "0x10D96F0", VA = "0x110DA8F0", Slot = "9")]
    protected override bool ReceiveData(byte[] data, int dataLength) => new bool();

    [Token(Token = "0x6003A42")]
    [Address(RVA = "0x10DA8D0", Offset = "0x10D96D0", VA = "0x110DA8D0", Slot = "12")]
    protected override void CompleteContent()
    {
    }

    [Token(Token = "0x6003A43")]
    [Address(RVA = "0x10DAAF0", Offset = "0x10D98F0", VA = "0x110DAAF0")]
    public DownloadLogger()
    {
    }
  }
}
