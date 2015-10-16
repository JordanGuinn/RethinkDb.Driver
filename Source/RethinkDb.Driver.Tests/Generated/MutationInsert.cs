




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
    public class MutationInsert : GeneratedTest {

        public MutationInsert (){
                tableVars.Add( "tbl" );
        }


            public static Table tbl = r.db(DbName).table("tbl");


        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #1
                 /* ExpectedOriginal: partial({'tables_created':1}) */
                 var expected_ = partial(r.hashMap("tables_created", 1L));
                 
                 /* Original: r.db('test').table_create('test2') */
                 var obtained = runOrCatch( r.db("test").tableCreate("test2") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             
             //JavaDef, mutation/insert.yaml, #2
             //Original: tbl2 = r.db('test').table('test2')
             
                 var tbl2 = (Table) (r.db("test").table("test2"));
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #3
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':1}) */
                 var expected_ = r.hashMap("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 1L);
                 
                 /* Original: tbl.insert({'id':0,'a':0}) */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 0L).with("a", 0L)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #4
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: tbl.count() */
                 var obtained = runOrCatch( tbl.count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #5
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':1}) */
                 var expected_ = r.hashMap("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 1L);
                 
                 /* Original: tbl.insert({'id':1, 'a':1}, durability='hard') */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 1L).with("a", 1L)).optArg("durability", "hard") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #6
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: tbl.count() */
                 var obtained = runOrCatch( tbl.count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #7
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':1}) */
                 var expected_ = r.hashMap("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 1L);
                 
                 /* Original: tbl.insert({'id':2, 'a':2}, durability='soft') */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 2L).with("a", 2L)).optArg("durability", "soft") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #8
                 /* ExpectedOriginal: 3 */
                 var expected_ = 3L;
                 
                 /* Original: tbl.count() */
                 var obtained = runOrCatch( tbl.count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #9
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Durability option `wrong` unrecognized (options are "hard" and "soft").', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Durability option `wrong` unrecognized (options are \"hard\" and \"soft\").", r.array(0L));
                 
                 /* Original: tbl.insert({'id':3, 'a':3}, durability='wrong') */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 3L).with("a", 3L)).optArg("durability", "wrong") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #10
                 /* ExpectedOriginal: 3 */
                 var expected_ = 3L;
                 
                 /* Original: tbl.count() */
                 var obtained = runOrCatch( tbl.count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #11
                 /* ExpectedOriginal: ({'deleted':1,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected_ = r.hashMap("deleted", 1L).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.get(2).delete() */
                 var obtained = runOrCatch( tbl.get(2L).delete() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #12
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':2}) */
                 var expected_ = r.hashMap("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 2L);
                 
                 /* Original: tbl.insert([{'id':2,'a':2}, {'id':3,'a':3}]) */
                 var obtained = runOrCatch( tbl.insert(r.array(r.hashMap("id", 2L).with("a", 2L), r.hashMap("id", 3L).with("a", 3L))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #13
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':4}) */
                 var expected_ = r.hashMap("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 4L);
                 
                 /* Original: tbl2.insert(tbl) */
                 var obtained = runOrCatch( tbl2.insert(tbl) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #14
                 /* ExpectedOriginal: ({'first_error':"Duplicate primary key `id`:\n{\n\t\"a\":\t2,\n\t\"id\":\t2\n}\n{\n\t\"b\":\t20,\n\t\"id\":\t2\n}",'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':1,'skipped':0.0,'inserted':0.0}) */
                 var expected_ = r.hashMap("first_error", "Duplicate primary key `id`:\n{\n\t\"a\":\t2,\n\t\"id\":\t2\n}\n{\n\t\"b\":\t20,\n\t\"id\":\t2\n}").with("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 1L).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.insert({'id':2,'b':20}) */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 2L).with("b", 20L)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #15
                 /* ExpectedOriginal: ({'first_error':"Duplicate primary key `id`:\n{\n\t\"a\":\t2,\n\t\"id\":\t2\n}\n{\n\t\"b\":\t20,\n\t\"id\":\t2\n}",'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':1,'skipped':0.0,'inserted':0.0}) */
                 var expected_ = r.hashMap("first_error", "Duplicate primary key `id`:\n{\n\t\"a\":\t2,\n\t\"id\":\t2\n}\n{\n\t\"b\":\t20,\n\t\"id\":\t2\n}").with("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 1L).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.insert({'id':2,'b':20}, conflict='error') */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 2L).with("b", 20L)).optArg("conflict", "error") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #16
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':1}) */
                 var expected_ = r.hashMap("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 1L);
                 
                 /* Original: tbl.insert({'id':15,'b':20}, conflict='error') */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 15L).with("b", 20L)).optArg("conflict", "error") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #17
                 /* ExpectedOriginal: ({'id':15,'b':20}) */
                 var expected_ = r.hashMap("id", 15L).with("b", 20L);
                 
                 /* Original: tbl.get(15) */
                 var obtained = runOrCatch( tbl.get(15L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #18
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':1,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected_ = r.hashMap("deleted", 0.0).with("replaced", 1L).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.insert({'id':2,'b':20}, conflict='replace') */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 2L).with("b", 20L)).optArg("conflict", "replace") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #19
                 /* ExpectedOriginal: ({'id':2,'b':20}) */
                 var expected_ = r.hashMap("id", 2L).with("b", 20L);
                 
                 /* Original: tbl.get(2) */
                 var obtained = runOrCatch( tbl.get(2L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #20
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':1}) */
                 var expected_ = r.hashMap("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 1L);
                 
                 /* Original: tbl.insert({'id':20,'b':20}, conflict='replace') */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 20L).with("b", 20L)).optArg("conflict", "replace") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #21
                 /* ExpectedOriginal: ({'id':20,'b':20}) */
                 var expected_ = r.hashMap("id", 20L).with("b", 20L);
                 
                 /* Original: tbl.get(20) */
                 var obtained = runOrCatch( tbl.get(20L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #22
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':1,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected_ = r.hashMap("deleted", 0.0).with("replaced", 1L).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.insert({'id':2,'c':30}, conflict='update') */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 2L).with("c", 30L)).optArg("conflict", "update") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #23
                 /* ExpectedOriginal: ({'id':2, 'b':20, 'c':30}) */
                 var expected_ = r.hashMap("id", 2L).with("b", 20L).with("c", 30L);
                 
                 /* Original: tbl.get(2) */
                 var obtained = runOrCatch( tbl.get(2L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #24
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':1}) */
                 var expected_ = r.hashMap("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 1L);
                 
                 /* Original: tbl.insert({'id':30,'b':20}, conflict='update') */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 30L).with("b", 20L)).optArg("conflict", "update") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #25
                 /* ExpectedOriginal: ({'id':30,'b':20}) */
                 var expected_ = r.hashMap("id", 30L).with("b", 20L);
                 
                 /* Original: tbl.get(30) */
                 var obtained = runOrCatch( tbl.get(30L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #26
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Conflict option `wrong` unrecognized (options are "error", "replace" and "update").', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Conflict option `wrong` unrecognized (options are \"error\", \"replace\" and \"update\").", r.array(0L));
                 
                 /* Original: tbl.insert({'id':3, 'a':3}, conflict='wrong') */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 3L).with("a", 3L)).optArg("conflict", "wrong") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             
             //JavaDef, mutation/insert.yaml, #27
             //Original: tblpkey = r.db('test').table('testpkey')
             
                 var tblpkey = (Table) (r.db("test").table("testpkey"));
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #27
                 /* ExpectedOriginal: partial({'tables_created':1}) */
                 var expected_ = partial(r.hashMap("tables_created", 1L));
                 
                 /* Original: r.db('test').table_create('testpkey', primary_key='foo') */
                 var obtained = runOrCatch( r.db("test").tableCreate("testpkey").optArg("primary_key", "foo") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #28
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'generated_keys':arrlen(1,uuid()),'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':1}) */
                 var expected_ = r.hashMap("deleted", 0.0).with("replaced", 0.0).with("generated_keys", arrlen(1L, uuid())).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 1L);
                 
                 /* Original: tblpkey.insert({}) */
                 var obtained = runOrCatch( tblpkey.insert(r.hashMap()) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #29
                 /* ExpectedOriginal: ([{'foo':uuid()}]) */
                 var expected_ = r.array(r.hashMap("foo", uuid()));
                 
                 /* Original: tblpkey */
                 var obtained = runOrCatch( tblpkey ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #30
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'generated_keys':arrlen(1,uuid()),'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':1}) */
                 var expected_ = r.hashMap("deleted", 0.0).with("replaced", 0.0).with("generated_keys", arrlen(1L, uuid())).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 1L);
                 
                 /* Original: tblpkey.insert({'b':20}, conflict='replace') */
                 var obtained = runOrCatch( tblpkey.insert(r.hashMap("b", 20L)).optArg("conflict", "replace") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #31
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'generated_keys':arrlen(1,uuid()),'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':1}) */
                 var expected_ = r.hashMap("deleted", 0.0).with("replaced", 0.0).with("generated_keys", arrlen(1L, uuid())).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 1L);
                 
                 /* Original: tblpkey.insert({'b':20}, conflict='update') */
                 var obtained = runOrCatch( tblpkey.insert(r.hashMap("b", 20L)).optArg("conflict", "update") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #32
                 /* ExpectedOriginal: partial({'tables_dropped':1}) */
                 var expected_ = partial(r.hashMap("tables_dropped", 1L));
                 
                 /* Original: r.db('test').table_drop('testpkey') */
                 var obtained = runOrCatch( r.db("test").tableDrop("testpkey") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #33
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':7}) */
                 var expected_ = r.hashMap("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 7L);
                 
                 /* Original: tbl.for_each(lambda  row:          tbl2.insert(row.merge({'id':row['id']  +  100 }))   ) */
                 var obtained = runOrCatch( tbl.forEach(row => tbl2.insert(row.merge(r.hashMap("id", row.bracket("id").add(100L))))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #34
                 /* ExpectedOriginal: partial({'errors':1,'first_error':'`r.minval` and `r.maxval` cannot be written to disk.'}) */
                 var expected_ = partial(r.hashMap("errors", 1L).with("first_error", "`r.minval` and `r.maxval` cannot be written to disk."));
                 
                 /* Original: tbl.insert({'value':r.minval}) */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("value", r.minval())) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #35
                 /* ExpectedOriginal: partial({'errors':1,'first_error':'`r.minval` and `r.maxval` cannot be written to disk.'}) */
                 var expected_ = partial(r.hashMap("errors", 1L).with("first_error", "`r.minval` and `r.maxval` cannot be written to disk."));
                 
                 /* Original: tbl.insert({'value':r.maxval}) */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("value", r.maxval())) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #36
                 /* ExpectedOriginal: err('ReqlQueryLogicError','Cannot convert `r.minval` to JSON.') */
                 var expected_ = err("ReqlQueryLogicError", "Cannot convert `r.minval` to JSON.");
                 
                 /* Original: r.minval */
                 var obtained = runOrCatch( r.minval() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #37
                 /* ExpectedOriginal: err('ReqlQueryLogicError','Cannot convert `r.maxval` to JSON.') */
                 var expected_ = err("ReqlQueryLogicError", "Cannot convert `r.maxval` to JSON.");
                 
                 /* Original: r.maxval */
                 var obtained = runOrCatch( r.maxval() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #38
                 /* ExpectedOriginal: partial({'tables_dropped':1}) */
                 var expected_ = partial(r.hashMap("tables_dropped", 1L));
                 
                 /* Original: r.db('test').table_drop('test2') */
                 var obtained = runOrCatch( r.db("test").tableDrop("test2") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
