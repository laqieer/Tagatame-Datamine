// Decompiled with JetBrains decompiler
// Type: SRPG.ChatLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002186")]
  public class ChatLog
  {
    [Token(Token = "0x400928F")]
    [FieldOffset(Offset = "0x8")]
    private List<ChatLogParam> add_log_list;
    [Token(Token = "0x4009290")]
    [FieldOffset(Offset = "0xC")]
    public List<ChatLogParam> messages;
    [Token(Token = "0x4009291")]
    [FieldOffset(Offset = "0x10")]
    public List<ChatLogOfficialParam> official_messages;
    [Token(Token = "0x4009292")]
    [FieldOffset(Offset = "0x14")]
    public bool is_dirty;
    [Token(Token = "0x4009293")]
    [FieldOffset(Offset = "0x18")]
    private long top_message_id_server;
    [Token(Token = "0x4009294")]
    [FieldOffset(Offset = "0x20")]
    private long last_message_id;
    [Token(Token = "0x4009295")]
    [FieldOffset(Offset = "0x28")]
    private long last_message_posted_at;
    [Token(Token = "0x4009296")]
    [FieldOffset(Offset = "0x30")]
    private long last_message_id_server;

    [Token(Token = "0x170013E4")]
    public long TopMessageIdServer
    {
      [Token(Token = "0x6008D10"), Address(RVA = "0x50D7F0", Offset = "0x50C5F0", VA = "0x1050D7F0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x170013E5")]
    public long LastMessageIdServer
    {
      [Token(Token = "0x6008D11"), Address(RVA = "0x50D7D0", Offset = "0x50C5D0", VA = "0x1050D7D0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x170013E6")]
    public long LastMessagePostedAt
    {
      [Token(Token = "0x6008D12"), Address(RVA = "0x3057C0", Offset = "0x3045C0", VA = "0x103057C0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x6008D13")]
    [Address(RVA = "0x50D6B0", Offset = "0x50C4B0", VA = "0x1050D6B0")]
    public ChatLog()
    {
    }

    [Token(Token = "0x6008D14")]
    [Address(RVA = "0x50D120", Offset = "0x50BF20", VA = "0x1050D120")]
    public void Clear()
    {
    }

    [Token(Token = "0x6008D15")]
    [Address(RVA = "0x50CCE0", Offset = "0x50BAE0", VA = "0x1050CCE0")]
    public void AddMessage(ChatLogParam _param)
    {
    }

    [Token(Token = "0x6008D16")]
    [Address(RVA = "0x50CD60", Offset = "0x50BB60", VA = "0x1050CD60")]
    public void AddMessage(List<ChatLogParam> _message)
    {
    }

    [Token(Token = "0x6008D17")]
    [Address(RVA = "0x50D080", Offset = "0x50BE80", VA = "0x1050D080")]
    public void AddMessage(List<ChatLogOfficialParam> official_messages)
    {
    }

    [Token(Token = "0x6008D18")]
    [Address(RVA = "0x50D620", Offset = "0x50C420", VA = "0x1050D620")]
    public void Reset()
    {
    }

    [Token(Token = "0x6008D19")]
    [Address(RVA = "0x50D5C0", Offset = "0x50C3C0", VA = "0x1050D5C0")]
    public void RemoveByIndex(int _index)
    {
    }

    [Token(Token = "0x6008D1A")]
    [Address(RVA = "0x50D3C0", Offset = "0x50C1C0", VA = "0x1050D3C0")]
    private void RefreshId()
    {
    }

    [Token(Token = "0x6008D1B")]
    [Address(RVA = "0x50D1E0", Offset = "0x50BFE0", VA = "0x1050D1E0")]
    public void Deserialize(JSON_ChatLog json)
    {
    }
  }
}
