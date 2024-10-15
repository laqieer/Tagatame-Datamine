// Decompiled with JetBrains decompiler
// Type: SRPG.WebAPI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using MessagePack;
using System.Text;
using UnityEngine.Networking;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200307A")]
  public abstract class WebAPI
  {
    [Token(Token = "0x400EBFC")]
    [FieldOffset(Offset = "0x8")]
    public string name;
    [Token(Token = "0x400EBFD")]
    [FieldOffset(Offset = "0xC")]
    public string body;
    [Token(Token = "0x400EBFE")]
    [FieldOffset(Offset = "0x10")]
    public SRPG.Network.ResponseCallback callback;
    [Token(Token = "0x400EBFF")]
    [FieldOffset(Offset = "0x14")]
    public readonly string GumiTransactionId;
    [Token(Token = "0x400EC00")]
    [FieldOffset(Offset = "0x18")]
    public WebAPI.RequestType reqtype;
    [Token(Token = "0x400EC01")]
    [FieldOffset(Offset = "0x1C")]
    public DownloadHandler dlHandler;
    [Token(Token = "0x400EC02")]
    [FieldOffset(Offset = "0x20")]
    private EncodingTypes.ESerializeCompressMethod ___serializeCompressMethod;
    [Token(Token = "0x400EC03")]
    [FieldOffset(Offset = "0x0")]
    private static StringBuilder mSB;

    [Token(Token = "0x17001D04")]
    public EncodingTypes.ESerializeCompressMethod serializeCompressMethod
    {
      [Token(Token = "0x600DCE3"), Address(RVA = "0xA7FDD0", Offset = "0xA7EBD0", VA = "0x10A7FDD0")] get
      {
        return new EncodingTypes.ESerializeCompressMethod();
      }
      [Token(Token = "0x600DCE4"), Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")] set
      {
      }
    }

    [Token(Token = "0x600DCE5")]
    [Address(RVA = "0xA7F970", Offset = "0xA7E770", VA = "0x10A7F970")]
    protected static StringBuilder GetStringBuilder() => (StringBuilder) null;

    [Token(Token = "0x600DCE6")]
    [Address(RVA = "0xA7F1C0", Offset = "0xA7DFC0", VA = "0x10A7F1C0")]
    public static string EscapeString(string s) => (string) null;

    [Token(Token = "0x600DCE7")]
    protected static string GetRequestString<T>(T param) => (string) null;

    [Token(Token = "0x600DCE8")]
    [Address(RVA = "0xA7F8B0", Offset = "0xA7E6B0", VA = "0x10A7F8B0")]
    protected static string GetRequestString(string body) => (string) null;

    [Token(Token = "0x600DCE9")]
    [Address(RVA = "0xA7F270", Offset = "0xA7E070", VA = "0x10A7F270")]
    protected static string GetBtlEndParamString(BattleCore.Record record, bool multi = false)
    {
      return (string) null;
    }

    [Token(Token = "0x600DCEA")]
    [Address(RVA = "0xA7FCD0", Offset = "0xA7EAD0", VA = "0x10A7FCD0")]
    public static string KeyValueToString(string key, string value) => (string) null;

    [Token(Token = "0x600DCEB")]
    [Address(RVA = "0xA7FC70", Offset = "0xA7EA70", VA = "0x10A7FC70")]
    public static string KeyValueToString(string key, bool value) => (string) null;

    [Token(Token = "0x600DCEC")]
    [Address(RVA = "0xA7FC10", Offset = "0xA7EA10", VA = "0x10A7FC10")]
    public static string KeyValueToString(string key, byte value) => (string) null;

    [Token(Token = "0x600DCED")]
    [Address(RVA = "0xA7FAF0", Offset = "0xA7E8F0", VA = "0x10A7FAF0")]
    public static string KeyValueToString(string key, short value) => (string) null;

    [Token(Token = "0x600DCEE")]
    [Address(RVA = "0xA7FBB0", Offset = "0xA7E9B0", VA = "0x10A7FBB0")]
    public static string KeyValueToString(string key, int value) => (string) null;

    [Token(Token = "0x600DCEF")]
    [Address(RVA = "0xA7FB50", Offset = "0xA7E950", VA = "0x10A7FB50")]
    public static string KeyValueToString(string key, long value) => (string) null;

    [Token(Token = "0x600DCF0")]
    [Address(RVA = "0xA7F9D0", Offset = "0xA7E7D0", VA = "0x10A7F9D0")]
    public static string KeyValueToString(string key, ushort value) => (string) null;

    [Token(Token = "0x600DCF1")]
    [Address(RVA = "0xA7FA30", Offset = "0xA7E830", VA = "0x10A7FA30")]
    public static string KeyValueToString(string key, uint value) => (string) null;

    [Token(Token = "0x600DCF2")]
    [Address(RVA = "0xA7FA90", Offset = "0xA7E890", VA = "0x10A7FA90")]
    public static string KeyValueToString(string key, ulong value) => (string) null;

    [Token(Token = "0x600DCF3")]
    [Address(RVA = "0xA7F140", Offset = "0xA7DF40", VA = "0x10A7F140")]
    public static string ConvBtlResultTypesToStatus(BtlResultTypes result) => (string) null;

    [Token(Token = "0x600DCF4")]
    [Address(RVA = "0xA7FD80", Offset = "0xA7EB80", VA = "0x10A7FD80")]
    protected WebAPI()
    {
    }

    [Token(Token = "0x600DCF5")]
    [Address(RVA = "0xA7FD10", Offset = "0xA7EB10", VA = "0x10A7FD10")]
    static WebAPI()
    {
    }

    [Token(Token = "0x200307B")]
    public enum RequestType
    {
      [Token(Token = "0x400EC05")] REQ_GSC,
      [Token(Token = "0x400EC06")] REQ_STREAM,
    }

    [Token(Token = "0x200307C")]
    [MessagePackObject(true)]
    public class JSON_BaseResponse
    {
      [Token(Token = "0x400EC07")]
      [FieldOffset(Offset = "0x8")]
      public int stat;
      [Token(Token = "0x400EC08")]
      [FieldOffset(Offset = "0xC")]
      public string stat_msg;
      [Token(Token = "0x400EC09")]
      [FieldOffset(Offset = "0x10")]
      public string stat_code;
      [Token(Token = "0x400EC0A")]
      [FieldOffset(Offset = "0x18")]
      public long time;
      [Token(Token = "0x400EC0B")]
      [FieldOffset(Offset = "0x20")]
      public int ticket;

      [Token(Token = "0x600DCF6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_BaseResponse()
      {
      }
    }

    [Token(Token = "0x200307D")]
    [MessagePackObject(true)]
    public class JSON_BodyResponse<T> : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400EC0C")]
      [FieldOffset(Offset = "0x0")]
      public T body;

      [Token(Token = "0x600DCF7")]
      public JSON_BodyResponse()
      {
      }
    }

    [Token(Token = "0x200307E")]
    protected class RequestParamWithTicketId<T>
    {
      [Token(Token = "0x400EC0D")]
      [FieldOffset(Offset = "0x0")]
      public int ticket;
      [Token(Token = "0x400EC0E")]
      [FieldOffset(Offset = "0x0")]
      public T param;

      [Token(Token = "0x600DCF8")]
      public RequestParamWithTicketId(int _ticket, T _param)
      {
      }
    }

    [Token(Token = "0x200307F")]
    internal class JSON_BodyResponse
    {
      [Token(Token = "0x600DCF9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_BodyResponse()
      {
      }
    }
  }
}
