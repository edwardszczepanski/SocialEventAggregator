package com.edwardszczepanski.socialapp;

import android.app.UiAutomation;
import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.net.Uri;

/**
 * Created by rober on 2/28/2016.
 */
public class DatabaseHandler extends SQLiteOpenHelper {

    public static final int DATABASE_VERSION = 1;

    private static final String DATABASE_NAME = "eventManager",
    TABLE_EVENTS = "events",
    KEY_ID = "id",
    KEY_NAME = "name",
    KEY_ADDRESS = "address";

    public DatabaseHandler(Context context) {
        super(context, DATABASE_NAME, null, DATABASE_VERSION);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL("CREATE TABLE" + TABLE_EVENTS + "(" + KEY_ID + "INTEGER PRIMARY KEY," + KEY_NAME + " TEXT," + KEY_ADDRESS + "TEXT)");
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("DROP TABLE IF EXISTS " + TABLE_EVENTS);

        onCreate(db);
    }

    public void createEvent(Event event) {
        SQLiteDatabase db = getWritableDatabase();

        ContentValues values = new ContentValues();

        values.put(KEY_NAME, event.getEventName());
        values.put(KEY_ADDRESS, event.getEventAddress());
        db.insert(TABLE_EVENTS, null, values);
        db.close();

    }

    public Event getEvent(int id) {
        SQLiteDatabase db = getReadableDatabase();

        Cursor cursor = db.query(TABLE_EVENTS, new String[] {KEY_ID, KEY_NAME, KEY_ADDRESS}, KEY_ID + "=?", new String[] { String.valueOf(id) }, null, null, null, null);

        if (cursor != null) {
            cursor.moveToFirst();
        }

        Event event = new Event(Integer.parseInt(cursor.getString(0)), cursor.getString(1), cursor.getString(2), "01012016"));
        return event;
    }
}
