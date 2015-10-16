




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;

namespace RethinkDb.Driver.Test.Generated {
    [TestFixture]
    public class TimesApi : GeneratedTest {

        public TimesApi (){
        }




        [Test]
        public void YamlTest(){

             
             //JavaDef, times/api.yaml, #1
             //Original: rt1 = 1375147296.6812
             
                 var rt1 = (double) (1375147296.6812);
             
             
             //JavaDef, times/api.yaml, #2
             //Original: t1 = r.epoch_time(rt1)
             
                 var t1 = (EpochTime) (r.epochTime(rt1));
             
             
             //JavaDef, times/api.yaml, #3
             //Original: t2 = r.epoch_time(rt1 + 1000)
             
                 var t2 = (EpochTime) (r.epochTime(r.add(rt1, 1000L)));
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #4
                 /* ExpectedOriginal: (1375148296.681) */
                 var expected_ = 1375148296.681;
                 
                 /* Original: (t1 + 1000).to_epoch_time() */
                 var obtained = runOrCatch( r.add(t1, 1000L).toEpochTime() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #5
                 /* ExpectedOriginal: (1375146296.681) */
                 var expected_ = 1375146296.681;
                 
                 /* Original: (t1 - 1000).to_epoch_time() */
                 var obtained = runOrCatch( r.sub(t1, 1000L).toEpochTime() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #6
                 /* ExpectedOriginal: 1000 */
                 var expected_ = 1000L;
                 
                 /* Original: (t1 - (t1 - 1000)) */
                 var obtained = runOrCatch( r.sub(t1, r.sub(t1, 1000L)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #7
                 /* ExpectedOriginal: False */
                 var expected_ = false;
                 
                 /* Original: (t1 < t1) */
                 var obtained = runOrCatch( r.lt(t1, t1) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #8
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: (t1 <= t1) */
                 var obtained = runOrCatch( r.le(t1, t1) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #9
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: (t1 == t1) */
                 var obtained = runOrCatch( r.eq(t1, t1) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #10
                 /* ExpectedOriginal: False */
                 var expected_ = false;
                 
                 /* Original: (t1 != t1) */
                 var obtained = runOrCatch( r.ne(t1, t1) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #11
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: (t1 >= t1) */
                 var obtained = runOrCatch( r.ge(t1, t1) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #12
                 /* ExpectedOriginal: False */
                 var expected_ = false;
                 
                 /* Original: (t1 > t1) */
                 var obtained = runOrCatch( r.gt(t1, t1) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #13
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: (t1 < t2) */
                 var obtained = runOrCatch( r.lt(t1, t2) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #14
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: (t1 <= t2) */
                 var obtained = runOrCatch( r.le(t1, t2) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #15
                 /* ExpectedOriginal: False */
                 var expected_ = false;
                 
                 /* Original: (t1 == t2) */
                 var obtained = runOrCatch( r.eq(t1, t2) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #16
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: (t1 != t2) */
                 var obtained = runOrCatch( r.ne(t1, t2) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #17
                 /* ExpectedOriginal: False */
                 var expected_ = false;
                 
                 /* Original: (t1 >= t2) */
                 var obtained = runOrCatch( r.ge(t1, t2) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #18
                 /* ExpectedOriginal: False */
                 var expected_ = false;
                 
                 /* Original: (t1 > t2) */
                 var obtained = runOrCatch( r.gt(t1, t2) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #19
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: t1.during(t1, t1 + 1000) */
                 var obtained = runOrCatch( t1.during(t1, r.add(t1, 1000L)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #20
                 /* ExpectedOriginal: False */
                 var expected_ = false;
                 
                 /* Original: t1.during(t1, t1 + 1000, left_bound='open') */
                 var obtained = runOrCatch( t1.during(t1, r.add(t1, 1000L)).optArg("left_bound", "open") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #21
                 /* ExpectedOriginal: False */
                 var expected_ = false;
                 
                 /* Original: t1.during(t1, t1) */
                 var obtained = runOrCatch( t1.during(t1, t1) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #22
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: t1.during(t1, t1, right_bound='closed') */
                 var obtained = runOrCatch( t1.during(t1, t1).optArg("right_bound", "closed") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #23
                 /* ExpectedOriginal: 1375142400 */
                 var expected_ = 1375142400L;
                 
                 /* Original: t1.date().to_epoch_time() */
                 var obtained = runOrCatch( t1.date().toEpochTime() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #24
                 /* ExpectedOriginal: (4896.681) */
                 var expected_ = 4896.681;
                 
                 /* Original: t1.time_of_day() */
                 var obtained = runOrCatch( t1.timeOfDay() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #25
                 /* ExpectedOriginal: 2013 */
                 var expected_ = 2013L;
                 
                 /* Original: t1.year() */
                 var obtained = runOrCatch( t1.year() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #26
                 /* ExpectedOriginal: 7 */
                 var expected_ = 7L;
                 
                 /* Original: t1.month() */
                 var obtained = runOrCatch( t1.month() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #27
                 /* ExpectedOriginal: 30 */
                 var expected_ = 30L;
                 
                 /* Original: t1.day() */
                 var obtained = runOrCatch( t1.day() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #28
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: t1.day_of_week() */
                 var obtained = runOrCatch( t1.dayOfWeek() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #29
                 /* ExpectedOriginal: 211 */
                 var expected_ = 211L;
                 
                 /* Original: t1.day_of_year() */
                 var obtained = runOrCatch( t1.dayOfYear() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #30
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: t1.hours() */
                 var obtained = runOrCatch( t1.hours() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #31
                 /* ExpectedOriginal: 21 */
                 var expected_ = 21L;
                 
                 /* Original: t1.minutes() */
                 var obtained = runOrCatch( t1.minutes() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #32
                 /* ExpectedOriginal: 36.681 */
                 var expected_ = 36.681;
                 
                 /* Original: t1.seconds() */
                 var obtained = runOrCatch( t1.seconds() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #33
                 /* ExpectedOriginal: (1375165800.1) */
                 var expected_ = 1375165800.1;
                 
                 /* Original: r.time(2013, r.july, 29, 23, 30, 0.1, "-07:00").to_epoch_time() */
                 var obtained = runOrCatch( r.time(2013L, r.july(), 29L, 23L, 30L, 0.1, "-07:00").toEpochTime() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #34
                 /* ExpectedOriginal: ("-07:00") */
                 var expected_ = "-07:00";
                 
                 /* Original: r.time(2013, r.july, 29, 23, 30, 0.1, "-07:00").timezone() */
                 var obtained = runOrCatch( r.time(2013L, r.july(), 29L, 23L, 30L, 0.1, "-07:00").timezone() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #38
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Expected type STRING but found NUMBER.", []) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type STRING but found NUMBER.", r.array());
                 
                 /* Original: r.time(2013, r.july, 29, 23).to_epoch_time() */
                 var obtained = runOrCatch( r.time(2013L, r.july(), 29L, 23L).toEpochTime() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #39
                 /* ExpectedOriginal: 1375081200 */
                 var expected_ = 1375081200L;
                 
                 /* Original: r.time(2013, r.july, 29, "-07:00").to_epoch_time() */
                 var obtained = runOrCatch( r.time(2013L, r.july(), 29L, "-07:00").toEpochTime() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #40
                 /* ExpectedOriginal: ("-07:00") */
                 var expected_ = "-07:00";
                 
                 /* Original: r.time(2013, r.july, 29, "-07:00").timezone() */
                 var obtained = runOrCatch( r.time(2013L, r.july(), 29L, "-07:00").timezone() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #43
                 /* ExpectedOriginal: 1375242965 */
                 var expected_ = 1375242965L;
                 
                 /* Original: r.iso8601("2013-07-30T20:56:05-07:00").to_epoch_time() */
                 var obtained = runOrCatch( r.iso8601("2013-07-30T20:56:05-07:00").toEpochTime() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #44
                 /* ExpectedOriginal: ("2013-07-30T20:56:05-07:00") */
                 var expected_ = "2013-07-30T20:56:05-07:00";
                 
                 /* Original: r.epoch_time(1375242965).in_timezone("-07:00").to_iso8601() */
                 var obtained = runOrCatch( r.epochTime(1375242965L).inTimezone("-07:00").toIso8601() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #45
                 /* ExpectedOriginal: ("PTYPE<TIME>") */
                 var expected_ = "PTYPE<TIME>";
                 
                 /* Original: r.now().type_of() */
                 var obtained = runOrCatch( r.now().typeOf() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #46
                 /* ExpectedOriginal: 0 */
                 var expected_ = 0L;
                 
                 /* Original: (r.now() - r.now()) */
                 var obtained = runOrCatch( r.now().sub(r.now()) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #47
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "ISO 8601 string has no time zone, and no default time zone was provided.", []) */
                 var expected_ = err("ReqlQueryLogicError", "ISO 8601 string has no time zone, and no default time zone was provided.", r.array());
                 
                 /* Original: r.iso8601("2013-07-30T20:56:05").to_iso8601() */
                 var obtained = runOrCatch( r.iso8601("2013-07-30T20:56:05").toIso8601() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #48
                 /* ExpectedOriginal: ("2013-07-30T20:56:05-07:00") */
                 var expected_ = "2013-07-30T20:56:05-07:00";
                 
                 /* Original: r.iso8601("2013-07-30T20:56:05", default_timezone='-07').to_iso8601() */
                 var obtained = runOrCatch( r.iso8601("2013-07-30T20:56:05").optArg("default_timezone", "-07").toIso8601() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #49
                 /* ExpectedOriginal: ([1, 2, 3, 4, 5, 6, 7]) */
                 var expected_ = r.array(1L, 2L, 3L, 4L, 5L, 6L, 7L);
                 
                 /* Original: r.expr([r.monday, r.tuesday, r.wednesday, r.thursday, r.friday, r.saturday, r.sunday]) */
                 var obtained = runOrCatch( r.expr(r.array(r.monday(), r.tuesday(), r.wednesday(), r.thursday(), r.friday(), r.saturday(), r.sunday())) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/api.yaml, #50
                 /* ExpectedOriginal: ([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12]) */
                 var expected_ = r.array(1L, 2L, 3L, 4L, 5L, 6L, 7L, 8L, 9L, 10L, 11L, 12L);
                 
                 /* Original: r.expr([r.january, r.february, r.march, r.april, r.may, r.june, r.july, r.august, r.september, r.october, r.november, r.december]) */
                 var obtained = runOrCatch( r.expr(r.array(r.january(), r.february(), r.march(), r.april(), r.may(), r.june(), r.july(), r.august(), r.september(), r.october(), r.november(), r.december())) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
