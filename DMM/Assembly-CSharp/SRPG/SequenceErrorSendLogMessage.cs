// Decompiled with JetBrains decompiler
// Type: SRPG.SequenceErrorSendLogMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000D89")]
  public class SequenceErrorSendLogMessage
  {
    [Token(Token = "0x400267D")]
    [FieldOffset(Offset = "0x8")]
    private SequenceErrorSendLogMessage.Message message;

    [Token(Token = "0x6003722")]
    [Address(RVA = "0x10A4770", Offset = "0x10A3570", VA = "0x110A4770")]
    public void Add(SceneBattle.MultiPlayCheck my, SceneBattle.MultiPlayCheck host)
    {
    }

    [Token(Token = "0x6003723")]
    [Address(RVA = "0x10A4200", Offset = "0x10A3000", VA = "0x110A4200")]
    public void AddLog(MultiSendLogBuffer logBuffer)
    {
    }

    [Token(Token = "0x6003724")]
    [Address(RVA = "0x10A4800", Offset = "0x10A3600", VA = "0x110A4800")]
    public void Send()
    {
    }

    [Token(Token = "0x6003725")]
    [Address(RVA = "0x10A4940", Offset = "0x10A3740", VA = "0x110A4940")]
    public SequenceErrorSendLogMessage()
    {
    }

    [Token(Token = "0x2000D8A")]
    [Serializable]
    public class Message
    {
      [Token(Token = "0x400267E")]
      [FieldOffset(Offset = "0x8")]
      public string questId;
      [Token(Token = "0x400267F")]
      [FieldOffset(Offset = "0xC")]
      public List<SequenceErrorSendLogMessage.MessagePack> messages;
      [Token(Token = "0x4002680")]
      [FieldOffset(Offset = "0x10")]
      public List<SequenceErrorSendLogMessage.MessageLog> logs;

      [Token(Token = "0x6003726")]
      [Address(RVA = "0x10A2420", Offset = "0x10A1220", VA = "0x110A2420")]
      public Message()
      {
      }

      [Token(Token = "0x6003727")]
      [Address(RVA = "0x10A23D0", Offset = "0x10A11D0", VA = "0x110A23D0")]
      public void Add(SequenceErrorSendLogMessage.MessagePack mp)
      {
      }
    }

    [Token(Token = "0x2000D8B")]
    [Serializable]
    public class MessagePack
    {
      [Token(Token = "0x4002681")]
      [FieldOffset(Offset = "0x8")]
      public List<SequenceErrorSendLogMessage.MesageUnitDiff> diff;
      [Token(Token = "0x4002682")]
      [FieldOffset(Offset = "0xC")]
      public SequenceErrorSendLogMessage.MessageData my;
      [Token(Token = "0x4002683")]
      [FieldOffset(Offset = "0x10")]
      public SequenceErrorSendLogMessage.MessageData host;

      [Token(Token = "0x6003728")]
      [Address(RVA = "0x10A20C0", Offset = "0x10A0EC0", VA = "0x110A20C0")]
      public MessagePack(SceneBattle.MultiPlayCheck m, SceneBattle.MultiPlayCheck h)
      {
      }
    }

    [Token(Token = "0x2000D8C")]
    [Serializable]
    public class MessageData
    {
      [Token(Token = "0x4002684")]
      [FieldOffset(Offset = "0x8")]
      public int playerID;
      [Token(Token = "0x4002685")]
      [FieldOffset(Offset = "0xC")]
      public int playerIndex;
      [Token(Token = "0x4002686")]
      [FieldOffset(Offset = "0x10")]
      public int turn;
      [Token(Token = "0x4002687")]
      [FieldOffset(Offset = "0x14")]
      public SequenceErrorSendLogMessage.MessageUnit[] units;
      [Token(Token = "0x4002688")]
      [FieldOffset(Offset = "0x18")]
      public string rnd;

      [Token(Token = "0x6003729")]
      [Address(RVA = "0x10A1C50", Offset = "0x10A0A50", VA = "0x110A1C50")]
      public MessageData(SceneBattle.MultiPlayCheck d)
      {
      }
    }

    [Token(Token = "0x2000D8D")]
    [Serializable]
    public class MesageUnitDiff
    {
      [Token(Token = "0x4002689")]
      [FieldOffset(Offset = "0x8")]
      public SequenceErrorSendLogMessage.MessageUnit my;
      [Token(Token = "0x400268A")]
      [FieldOffset(Offset = "0xC")]
      public SequenceErrorSendLogMessage.MessageUnit host;

      [Token(Token = "0x600372A")]
      [Address(RVA = "0x3C0020", Offset = "0x3BEE20", VA = "0x103C0020")]
      public MesageUnitDiff(
        SequenceErrorSendLogMessage.MessageUnit _my,
        SequenceErrorSendLogMessage.MessageUnit _host)
      {
      }
    }

    [Token(Token = "0x2000D8E")]
    [Serializable]
    public class MessageUnit
    {
      [Token(Token = "0x400268B")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x400268C")]
      [FieldOffset(Offset = "0x10")]
      public long iid;
      [Token(Token = "0x400268D")]
      [FieldOffset(Offset = "0x18")]
      public int hp;
      [Token(Token = "0x400268E")]
      [FieldOffset(Offset = "0x1C")]
      public int x;
      [Token(Token = "0x400268F")]
      [FieldOffset(Offset = "0x20")]
      public int y;
      [Token(Token = "0x4002690")]
      [FieldOffset(Offset = "0x24")]
      public int dir;

      [Token(Token = "0x600372B")]
      [Address(RVA = "0x10A2380", Offset = "0x10A1180", VA = "0x110A2380")]
      public MessageUnit(string _iname, long _iid, int _hp, int _x, int _y, int _dir)
      {
      }

      [Token(Token = "0x600372C")]
      [Address(RVA = "0x10A2320", Offset = "0x10A1120", VA = "0x110A2320")]
      public SequenceErrorSendLogMessage.MessageUnit.EqualType IsEqual(
        SequenceErrorSendLogMessage.MessageUnit unit)
      {
        return new SequenceErrorSendLogMessage.MessageUnit.EqualType();
      }

      [Token(Token = "0x2000D8F")]
      public enum EqualType
      {
        [Token(Token = "0x4002692")] FailedIID,
        [Token(Token = "0x4002693")] Equal,
        [Token(Token = "0x4002694")] NotEqual,
      }
    }

    [Token(Token = "0x2000D90")]
    [Serializable]
    public class MessageLog
    {
      [Token(Token = "0x4002695")]
      [FieldOffset(Offset = "0x8")]
      public string c;
      [Token(Token = "0x4002696")]
      [FieldOffset(Offset = "0xC")]
      public int turn;
      [Token(Token = "0x4002697")]
      [FieldOffset(Offset = "0x10")]
      public int ui;
      [Token(Token = "0x4002698")]
      [FieldOffset(Offset = "0x14")]
      public int ti;
      [Token(Token = "0x4002699")]
      [FieldOffset(Offset = "0x18")]
      public string s;
      [Token(Token = "0x400269A")]
      [FieldOffset(Offset = "0x1C")]
      public string i;
      [Token(Token = "0x400269B")]
      [FieldOffset(Offset = "0x20")]
      public int gx;
      [Token(Token = "0x400269C")]
      [FieldOffset(Offset = "0x24")]
      public int gy;
      [Token(Token = "0x400269D")]
      [FieldOffset(Offset = "0x28")]
      public bool ul;
      [Token(Token = "0x400269E")]
      [FieldOffset(Offset = "0x2C")]
      public int d;

      [Token(Token = "0x600372D")]
      [Address(RVA = "0x10A2090", Offset = "0x10A0E90", VA = "0x110A2090")]
      public MessageLog()
      {
      }
    }
  }
}
