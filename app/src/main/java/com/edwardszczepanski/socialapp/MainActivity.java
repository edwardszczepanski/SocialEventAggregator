package com.edwardszczepanski.socialapp;
//Reference: Contains adaptations from John Manson contact list app, see https://www.youtube.com/watch?v=h7w3bveUfFA.
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.View;
import android.view.Menu;
import android.view.MenuItem;
import android.view.ViewGroup;
import android.view.Window;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TabHost;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;


public class MainActivity extends AppCompatActivity {

    EditText eventText, addressText, descriptionText;       //Holds user event creater text field entries.
    List<Event> Events = new ArrayList<Event>();            //ArrayList to hold events to be displayed (later will hold all events pulled from DB.
    ListView eventListView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        FloatingActionButton fab = (FloatingActionButton) findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
            }
        });

        eventText = (EditText) findViewById(R.id.txtEvent);         //EditText variables holding event creation info.
        addressText = (EditText) findViewById(R.id.txtAddress);
        descriptionText = (EditText) findViewById(R.id.txtDescription);
        eventListView = (ListView) findViewById(R.id.listView);

        final Button addEventBtn = (Button) findViewById(R.id.btnEventAdd);
            addEventBtn.setOnClickListener(new View.OnClickListener() {
                public void onClick(View v) {
                    addEvent(eventText.getText().toString(), addressText.getText().toString(), "01012016"); //Placeholder: need to add descrip. param & real timestamp (not int).

                    populateList();
                    Toast.makeText(getApplicationContext(), "Your event has been created!", Toast.LENGTH_SHORT).show(); //Displays message to user.
                }
            });

       TabHost tabHost = (TabHost) findViewById(R.id.tabHost);
       tabHost.setup();


       TabHost.TabSpec tabSpec = tabHost.newTabSpec("creator");         //Tab details for "Create Event" tab.
        tabSpec.setContent(R.id.tabCreateEvent);
        tabSpec.setIndicator("Create Event");
        tabHost.addTab(tabSpec);

        tabSpec = tabHost.newTabSpec("list");                           //Tab details for "Event List" tab.
        tabSpec.setContent(R.id.tabListEvent);
        tabSpec.setIndicator("Event List");
        tabHost.addTab(tabSpec);

        tabSpec = tabHost.newTabSpec("map");                            //Tab details for "Event Map" tab.
        tabSpec.setContent(R.id.tabMapEvent);
        tabSpec.setIndicator("Event Map");
        tabHost.addTab(tabSpec);







        eventText.addTextChangedListener(new TextWatcher() {            //Event listener for text field entry.
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {

            }

            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {
               addEventBtn.setEnabled(!eventText.getText().toString().trim().isEmpty());
            }

            @Override
            public void afterTextChanged(Editable s) {

            }
        });



    }

    private void populateList() {
        ArrayAdapter<Event> adapter = new EventListAdapter();
        eventListView.setAdapter(adapter);
    }

    /**
     * Adds a new event to Events ArrayList.
     * @param eName
     * @param eAddress
     * @param tStamp
     */
    private void addEvent(String eName, String eAddress, String tStamp) {
        Events.add(new Event(0, eName, eAddress, tStamp));
    }


    private class EventListAdapter extends ArrayAdapter<Event> {
        public EventListAdapter() {
            super(MainActivity.this, R.layout.listview_item, Events);
        }

        @Override
        public View getView(int position, View view, ViewGroup parent) {
            if (view == null) {
                view = getLayoutInflater().inflate(R.layout.listview_item, parent, false);
            }

            Event currentEvent = Events.get(position);

            TextView name = (TextView) view.findViewById(R.id.eventName);
            name.setText(currentEvent.getEventName());
            TextView address = (TextView) view.findViewById(R.id.eventAddress);
            address.setText(currentEvent.getEventAddress());
            TextView time = (TextView) view.findViewById(R.id.timeStamp);
            time.setText(currentEvent.getTimeStamp());

            return view;
        }
    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }
}
